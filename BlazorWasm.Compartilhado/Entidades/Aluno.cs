using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasm.Compartilhado.Entidades
{
    public class Aluno : IEntity 
    {
        public int Id { get; set; }
        
        [NotMapped]
        public int RA { get { return this.Id; }  }
        public string Nome { get; set; }
        public string Serie_Ano { get; set; }
        public string Contato { get; set; }
        public string Nascimento { get; set; }
    }
}
