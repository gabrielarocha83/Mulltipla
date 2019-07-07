using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulltiplaJML.Models.Invent
{
    public class OrdemServico
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nº OS")]
        public string NumeroOS { get; set; }
        [Display(Name = "Nº Pedido")]
        public string NumeroPedido { get; set; }
        [Display(Name = "Chave")]
        public string ChaveNF { get; set; }
        [Display(Name = "Dt. Rec.")]
        public string DataRecebimento { get; set; }
        [Display(Name = "Dt OS")]
        public string DataOS { get; set; }
        [Display(Name = "Cód. Forn")]
        public string CodFornecedor { get; set; }
        [Display(Name = "Forncedor")]
        public string NomeFornecedor { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        [Display(Name = "Tipo Recebimento")]
        public int TipoRecebimento { get; set; }
        [Display(Name = "Vl. Total")]
        public string ValorTotal { get; set; }
        [Display(Name = "Nota ou Pedido")]
        public string NotaPedido { get; set; }
        [Display(Name = "Forncedor")]
        public string RazaoSocialFornecedor { get; set; }
        [Display(Name = "CNPJ Forn.")]
        public string CNPJFornecedor { get; set; }
        [Display(Name = "Filial")]
        public string RazaoSocialFilial { get; set; }
        [Display(Name = "Filial")]
        public string NomeFilial { get; set; }
        [Display(Name = "CNPJ Filial")]
        public string CNPJFilial { get; set; }
        [Display(Name = "Matriz")]
        public string RazaoSocialMatriz { get; set; }
        [Display(Name = "Matriz")]
        public string NomeMatriz { get; set; }
        [Display(Name = "CNPJ Matriz")]
        public string CNPJmatriz { get; set; }
        public int CodMatriz { get; set; }
        public int CodFilial { get; set; }
        public int IdUsuario { get; set; }

        [Display(Name = "Tipo Ordem Serviço")]
        public string TipoOS { get; set; }
        [NotMapped]
        public List<ItensOrdemServico> itensOrdemServicos { get; set; }
    }
}
