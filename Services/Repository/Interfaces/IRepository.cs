using Domain.Model;
using System.Linq.Expressions;

namespace Services.Repository.Interfaces
{
    public interface IRepository<T> where T : Tarefa
    {
        void Add(T entity);
        Task<T> GetById(Expression<Func<T, bool>> expression);
        void Delete(T entity);
        IQueryable<T> GetAll(int skip, int take);
        IQueryable<T> GetTarefasAbertas(int skip, int take);
        IQueryable<T> GetTarefasConcluidas(int skip, int take);
        IQueryable<T> GetTarefasExcluidas(int skip, int take);
        IQueryable<T> GetTarefasAtrasadas(int skip, int take);
        void UpdateTarefa(T entity);
        
    }
}
