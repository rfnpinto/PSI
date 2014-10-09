using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaskPlaner.Models
{
    public abstract class Tarefa
    {
        public int ID { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O Titulo deve ter menos de 50 caracteres;")]
        public string Titulo { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "O tamanho maximo da nota é 250 caracteres;")]
        public int Nota { get; set; }

        [Required]
        public bool Lido { get; set; } 
    }
}