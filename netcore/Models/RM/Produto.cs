using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string CodigoProdutoRM { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string Valor { get; set; }
    }
}
