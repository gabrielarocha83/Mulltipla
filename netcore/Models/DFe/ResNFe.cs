using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.DFe
{
    public class ResNFe : INetcoreBasic
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Chave")]
        public string ChNFe { get; set; }
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }
        [Display(Name = "CPF")]
        public string CPF { get; set; }
        [Display(Name = "Nome")]
        public string XNome { get; set; }
        [Display(Name = "Inscrição Estadual")]
        public string IE { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DhEmi { get; set; }
        public string TpNF { get; set; }
       /* [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]*/
        [Display(Name = "Valor")]
        public string VNF { get; set; }
        public string DigVal { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DhRecbTo { get; set; }
        public string NProt { get; set; }
        [Display(Name = "Situação NFE")]
        public string CSitNFe { get; set; }
        [Display(Name = "CNPJ Tomador")]
        public string CnpjTomador { get; set; }
        public int? Manifesta { get; set; }
        public DateTime? DataManifestacao { get; set; }
        public string NSU { get; set; }
        [Display(Name = "Tipo Evento")]
        public string TipoEvento { get; set; }
        public string Observacao { get; set; }
    }
}
