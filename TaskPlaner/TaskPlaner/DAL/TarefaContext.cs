using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TaskPlaner.DAL
{
    public class TarefaContext : DbContext
    {
        public TarefaContext():base("TarefaCoontext")
    }
}