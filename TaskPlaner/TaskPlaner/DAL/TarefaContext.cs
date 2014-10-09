using TaskPlaner.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TaskPlaner.DAL
{
    public class TarefaContext : DbContext
    {
        public TarefaContext():base("TarefaCoontext")
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}