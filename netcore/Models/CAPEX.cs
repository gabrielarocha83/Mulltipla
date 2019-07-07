using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models
{
    public class CAPEX
    {
        [Key]
        public int Id { get; set; }
        public string CodProjeto { get; set; }
        public string Descricao { get; set; }
    }
    public class ItensCAPEX
    {
        [Key]
        public int Id { get; set; }
        public string CodItem { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }

    }
}
