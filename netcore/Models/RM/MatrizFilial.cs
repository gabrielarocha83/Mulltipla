using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
    public class MatrizFilial
    {
        [Key]
        public int Id { get; set; }
        public string Matriz { get; set; }
        public string Filial { get; set; }
        public int CodMatriz { get; set; }
        public int CodFilial { get; set; }
    }
}
