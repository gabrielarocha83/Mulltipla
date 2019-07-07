using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }
        public string TipodeSolicitacao { get; set; }
        public DateTime Vencimento { get; set; }
        public string TipodeMovimentação { get; set; }
        public string FormadePagto { get; set; }
        public string Fornecedor { get; set; }
        public string CPFCNPJ { get; set; }
        public string CondicaodePgto { get; set; }
        public string QtdeParc { get; set; }
        public string NumLotePedido { get; set; }
        public string NumNF { get; set; }
        public DateTime EmissaoNF { get; set; }
        public string ValorTotal { get; set; }
        public string ContaContabil { get; set; }
        public string Empresa { get; set; }
        public string Reembolsável { get; set; }
        public string Cliente { get; set; }
        public string AtivaçãoBem { get; set; }
        public string DescriçãoPagto { get; set; }
        public string NPatrimônio { get; set; }
        public string NSérie { get; set; }
        public string Qtde { get; set; }
        public string ValorUnitario { get; set; }

        public string AprovadoGestor { get; set; }
        public string MotivoAprovGestor { get; set; }
        public string AprovadoDiretor { get; set; }
        public string MotivoAprovDiretor { get; set; }
        public string AprovadoPresidente { get; set; }
        public string MotivoAprovPresidente { get; set; }

        public List<CentroCusto> centroCustos { get; set; }

    }
    public class CentroCusto
    {
        public int Id { get; set; }
        public int IdPagamento { get; set; }
        public string CodCentroCusto { get; set; }
        public string DescricaoCentroCusto { get; set; }
        public string Rateio { get; set; }
        public string Filial { get; set; }
        public string Operacao { get; set; }
        public string Produto { get; set; }
        public string Valor { get; set; }
    }
}
