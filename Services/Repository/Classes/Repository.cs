using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Services.Repository.Interfaces;
using System.Linq.Expressions;

namespace Services.Repository.Classes
{
    public class Repository<T> : IRepository<T> where T : Tarefa
    {

        private readonly TarefaContext _context;

        private DbSet<T> _entities;

        public Repository(TarefaContext context) 
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new Exception("Erro ao Adicionar tarefa");
            }

            if (entity.DataFechamento < DateTime.Now)
            {
                entity.Status = TarefaEnum.Atrasada;
            }

            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new Exception("Erro ao Adicionar tarefa");
            }

            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll(int skip, int take)
        {
            try
            {
                return _entities.AsNoTracking().Skip(skip).Take(take).Where(x => x.Status != TarefaEnum.Excluida && x.Status != TarefaEnum.Atrasada).AsQueryable();
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um Erro {ex}");
            }
            
        }

        public async Task<T> GetById(Expression<Func<T, bool>> expression)
        {
            try
            {
                return await _entities.SingleOrDefaultAsync(expression);
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um Erro {ex}");
            }
        }

        public IQueryable<T> GetTarefasAbertas(int skip, int take)
        {
            try
            {
                return _entities.AsNoTracking().Skip(skip).Take(take).Where(x => x.Status == TarefaEnum.Aberta).AsQueryable();
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um Erro {ex}");
            }
        }

        public IQueryable<T> GetTarefasConcluidas(int skip, int take)
        {
            try
            {
                return _entities.AsNoTracking().Skip(skip).Take(take).Where(x => x.Status == TarefaEnum.Concluida).AsQueryable();
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um Erro {ex}");
            }
        }

        public IQueryable<T> GetTarefasExcluidas(int skip, int take)
        {
            try
            {
                return _entities.AsNoTracking().Skip(skip).Take(take).Where(x => x.Status == TarefaEnum.Excluida).AsQueryable();
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um Erro {ex}");
            }
        }

        public IQueryable<T> GetTarefasAtrasadas(int skip, int take)
        {
            try
            {
                return _entities.AsNoTracking().Skip(skip).Take(take).Where(x => x.Status == TarefaEnum.Atrasada).AsQueryable();
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um Erro {ex}");
            }
        }

        public void UpdateTarefa(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new Exception("Erro ao Atualizar tarefa");
                }

                if (entity.DataFechamento < DateTime.Now && entity.Status != TarefaEnum.Excluida)
                {
                    entity.Status = TarefaEnum.Atrasada;
                }

                _entities.Update(entity);
                _context.SaveChanges();   
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um Erro {ex}");
            }
        }
    }
}
