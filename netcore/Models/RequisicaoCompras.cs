using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models
{
    public class RequisicaoCompras
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Filial Beneficiada")]
        public string FilialBeneficiada { get; set; }
        [Display(Name = "Depto Solicitante")]
        public string DeptoSolicitante { get; set; }
        [Display(Name = "Depto Beneficiado")]
        public string DeptoBeneficiado { get; set; }
        [Display(Name = "Centro de Custo")]
        public string CentrodeCusto { get; set; }
        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Display(Name = "Solicitante")]
        public string Solicitante { get; set; }
        [Display(Name = "Gerente/ Diretor")]
        public string GerenteDiretor { get; set; }
        [Display(Name = "Diretoria")]
        public string Diretoria { get; set; }

        [Display(Name = "Aprovado")]
        public bool AprovadoSolicitante { get; set; }
        [Display(Name = "Aprovado")]// 0 - Não, 1 - Sim
        public bool AprovadoGerenteDiretor { get; set; }
        [Display(Name = "Aprovado")]// 0 - Não, 1 - Sim
        public bool AprovadoDiretoria { get; set; }  // 0 - Não, 1 - Sim

        [Display(Name = "Data")]
        public DateTime DataSolicitante { get; set; }
        [Display(Name = "Data")]
        public DateTime DataGerenteDiretor { get; set; }
        [Display(Name = "Data")]
        public DateTime DataDiretoria { get; set; }


        public List<ItensRequisicaoCompras> itensRequisicaoCompras { get; set; }
        public List<Cotacoes> cotacoes { get; set; }
    }
    public class ItensRequisicaoCompras
    {
        [Key]
        public int Id { get; set; }
        public int IdRequisicaoCompras { get; set; }
        [Display(Name = "Código Produto")]
        public string CodProduto { get; set; }
        [Display(Name = "Produto")]
        public string DescricaoProduto { get; set; }
        public string Finalidade { get; set; }
        public string Quantidade { get; set; }
        [Display(Name = "Unidade Medida")]
        public string UnidadeMedida { get; set; }
        [Display(Name = "Produto / Serviço")]
        public string TipoPS { get; set; } // Produto/Servico
        public string Valor { get; set; }
        public string EspecTecnicas { get; set; }
        public string Observaçoes { get; set; }

    }
    public class Cotacoes
    {
        [Key]
        public int Id { get; set; }
        public int IdRequisicaoCompras { get; set; }
        public string Empresa { get; set; }
        public string Quantidade { get; set; }
        [Display(Name = "Valor Unitário")]
        public string ValorUnitario { get; set; }
        public string Total { get; set; }
        public string Frete { get; set; }
        [Display(Name = "Total Cotação")]
        public string TotalCotacao { get; set; }
        public string Pagamento { get; set; }
        public string Entrega { get; set; }
       

    }
}
