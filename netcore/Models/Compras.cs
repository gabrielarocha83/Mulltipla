using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models
{
    public class Compras
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome: ")]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Cargo: ")]
        public string Cargo { get; set; }

        [Display(Name = "Área: ")]
        public string Area { get; set; }

        [Display(Name = "Centro de Custo: ")]
        public string CentroCusto { get; set; }

        [Display(Name = "Coligada / Filiada: ")]
        public string Empresa { get; set; }

        [Display(Name = "Produto")]
        public bool TipoProduto { get; set; }

        [Display(Name = "Serviço")]
        public string TipoServico { get; set; }

        [Display(Name = "Prazo de Entrega:")]
        public PrazosEntrega PrazoEntrega { get; set; }

        [Display(Name = "Departamento")]
        public string Departamento { get; set; }

        [Display(Name = "Processo")]
        public string Processo { get; set; }

        [Display(Name = "Data Solicitação"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataSolicitacao { get; set; }

        [Display(Name = "Motivo: (Preencher no caso do emergencial)")]
        public string Motivo { get; set; }

        public string Fornecedor { get; set; }
        public string Tributos { get; set; }

        public string TotalGeral { get; set; }

        public string Movimento { get; set; }
        [Display(Name = "Data Entrega"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataEntrega { get; set; }
        [Display(Name = "Data Vencimento") , DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataVencimento { get; set; }

        [Display(Name = "Condição Pagamento")]
        public string CondicaoPagamento { get; set; }

        public string Status { get; set; }

        public List<ItensCompra> itensCompras { get; set; }
        public TipoCompras tipoCompras { get; set; }
        public ComprasCAPEX comprasCAPEX { get; set; }
    }
    public class ItensCompra
    {
        [Key]
        public int Id { get; set; }
        public int IdCompras { get; set; }
       
        [Display(Name = "QTDE:")]
        public string Quantidade { get; set; }
        public string UnidadeMedida { get; set; }
        public string CodProduto { get; set; }
        public string Produto { get; set; }
        public string ValorUnitario { get; set; }
        public string ValorTotal { get; set; }
        public string EspecificaçãoTecnica { get; set; }
    }
    public class TipoCompras
    {
        [Key]
        public int Id { get; set; }
        public int IdCompras { get; set; }
        public string TipoCotacao { get; set; }
        public string Justificativa { get; set; }
        public string Observação { get; set; }
        public string AtivarBem { get; set; }
        public string CAPEX { get; set; }
        public string Anexo { get; set; }
    }
    public class ComprasCAPEX
    {
        [Key]
        public int Id { get; set; }
        public int IdCompras { get; set; }
        public string DescricaoProjeto { get; set; }
        public string CodProjeto { get; set; }
        public string Justificativa { get; set; }
        public string Observação { get; set; }
        public string AtivarBem { get; set; }
        public string CAPEX { get; set; }
        public string Anexo { get; set; }
    }

    public class PrazosEntrega
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
