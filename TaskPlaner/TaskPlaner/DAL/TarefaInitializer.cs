using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskPlaner.Models;

namespace TaskPlaner.DAL
{
    public class TarefaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TarefaContext>
    {
        protected override void Seed(TarefaContext context)
        {
            var tarefas = new List<Tarefa> { new Tarefa { Data = DateTime.Now, Titulo = " asd ", Nota = "asdasdasdasdasdas", Lido = false } };

            tarefas.ForEach(s => context.Tarefas.Add(s));
            context.SaveChanges();
        }
    }
}