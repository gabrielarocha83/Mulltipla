using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
    public class FCFO
    {
        [Key]
        public int Id { get; set; }
        public string CODCFO { get; set; }
        public string DESCRICAO { get; set; }
      

    }
}
