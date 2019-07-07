using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.XML
{
    public class GDXMLHEADER
    {
        [Key]
        public int ID { get; set; }
        public string CHAVE { get; set; }
        public string CUF { get; set; }
        public string CNF { get; set; }
        public string NATOP { get; set; }
        public string INDPAG { get; set; }
        public string MOD { get; set; }
        public string SERIE { get; set; }
        public string NNF { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string DEMI { get; set; }
        public string DSAIENT { get; set; }
        public string HSAIENT { get; set; }
        public string TPNF { get; set; }
        public string CMUNFG { get; set; }
        public string TPIMP { get; set; }
        public string TPEMIS { get; set; }
        public string CDV { get; set; }
        public string TPAMB { get; set; }
        public string FINNFE { get; set; }
        public string PROCEMI { get; set; }
        public string VERPROC { get; set; }
        public string CNPJEMITENTE { get; set; }
        public string CNPJDESTINATARIO { get; set; }
        public string DVENC { get; set; }
        public string INFCPL { get; set; }
        public string VBC { get; set; }
        public string VICMS { get; set; }
        public string VBCST { get; set; }
        public string VST { get; set; }
        public string VPROD { get; set; }
        public string VFRETE { get; set; }
        public string VSEG { get; set; }
        public string VDESC { get; set; }
        public string VII { get; set; }
        public string VIPI { get; set; }
        public string VPIS { get; set; }
        public string VCOFINS { get; set; }
        public string VOUTRO { get; set; }
        public string VNF { get; set; }
        public string VTOTTRIB { get; set; }

        public string NomeRemetente { get; set; }
        public string NomeDestinatario { get; set; }


        [NotMapped]
        public GDXML GDXML { get; set; }

        [NotMapped]
        public IEnumerable<RMPEDIDOS> RMPEDIDOS { get; set; }

        [NotMapped]
        [Display(Name = "Pedidos")]
        public List<INTEGRAPEDIDO> Pedidos { get; set; }
    }
}
