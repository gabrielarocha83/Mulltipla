using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
    public class CentrodeCusto
    {
        [Key]
        public int Id { get; set; }
        public string CodigoCentrocusto { get; set; }
        public string Descricao { get; set; }
        
    }
}
