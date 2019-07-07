using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.Invent
{
    public class ItensOrdemServico
    {
        [Key]
        public int Id { get; set; }
        public string CodProduto { get; set; }
        public string Descricao { get; set; }
        public string Qtd { get; set; }
        public string Unidade { get; set; }
        public string Valor { get; set; }
        public string ValorTotal { get; set; }
        public int Recebido { get; set; }
        public string NumeroPedido { get; set; }
        public int TipoRecebimento { get; set; }
        public string DataRecebimento { get; set; }
        public string QtdRecebida { get; set; }
    }
}
