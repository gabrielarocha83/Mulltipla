using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.XML
{
    public class GDXMLITENS
    {
        [Key]
        public int ID { get; set; }
        public string CHNFE { get; set; }
        public string VERAPLIC { get; set; }
        public string CPROD { get; set; }
        public string XPROD { get; set; }
        public string NCM { get; set; }
        public string CFOP { get; set; }
        public string UCOM { get; set; }
        public string QCOM { get; set; }
        public string VUNCOM { get; set; }
        public string VPROD { get; set; }
        public string CEANTRIB { get; set; }
        public string UTRIB { get; set; }
        public string QTRIB { get; set; }
        public string VUNTRIB { get; set; }
        public string INDTOT { get; set; }
        public string CEAN { get; set; }
        public string ICMS_ORI { get; set; }
        public string ICMS_CST { get; set; }
        public string ICMS_VBCSTRET { get; set; }
        public string ICMS_VICMSSTRETI { get; set; }
        public string IPI_CENQ { get; set; }
        public string IPI_CST { get; set; }
        public string PIS_CST { get; set; }
        public string PIS_VBC { get; set; }
        public string PIS_PPIS { get; set; }
        public string PIS_VPIS { get; set; }
        public string COFINS_CST { get; set; }
        public string COFINS_VBC { get; set; }
        public string COFINS_PCOFINS { get; set; }
        public string COFINS_VCOFINS { get; set; }
    }
}
