using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class TarefaContext : DbContext
    {

        public TarefaContext()
        {

        }

        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options) { }
       
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}

