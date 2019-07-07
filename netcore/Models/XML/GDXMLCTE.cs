using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.XML
{
    public class GDXMLCTE
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Chave")]
        public string chCte { get; set; }
        [Display(Name = "UF")]
        public Nullable<int> cUF { get; set; }
        [Display(Name = "Código Cte")]
        public string cCT { get; set; }
        [Display(Name = "Nat. Operação")]
        public string natOp { get; set; }
        [Display(Name = "Forma pagto")]
        public Nullable<int> forPag { get; set; }
        [Display(Name = "Modalidade")]
        public Nullable<int> mod { get; set; }
        [Display(Name = "Série")]
        public Nullable<int> serie { get; set; }
        [Display(Name = "N Cte")]
        public Nullable<int> nCT { get; set; }
        [Display(Name = "Data Emissão")]
        public Nullable<System.DateTime> dhEmi { get; set; }
        public Nullable<int> tpImp { get; set; }
        [Display(Name = "Tipo Emissão")]
        public Nullable<int> tpEmis { get; set; }
        public Nullable<int> cDV { get; set; }
        public Nullable<int> tpAmb { get; set; }
        [Display(Name = "Tipo Cte")]
        public Nullable<int> tpCTe { get; set; }
        public Nullable<int> procEmi { get; set; }
        [Display(Name = "Versão")]
        public string verProc { get; set; }
        [Display(Name = "Código Município")]
        public string cMunEnv { get; set; }
        [Display(Name = "Descrição")]
        public string xMunEnv { get; set; }
        [Display(Name = "UF Envio")]
        public string UFEnv { get; set; }
        public string modal { get; set; }
        public Nullable<int> tpServ { get; set; }
        public string cMunIni { get; set; }
        public string xml { get; set; }
        [Display(Name = " Código de Situação Tributária")]
        public Nullable<decimal> CST { get; set; }
        public Nullable<decimal> vBC { get; set; }
        public Nullable<decimal> pICMS { get; set; }
        public Nullable<decimal> vICMS { get; set; }
        public Nullable<int> Integrado { get; set; }
        public string Emitente { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        [Display(Name = "Valor Total")]
        public Nullable<decimal> vTPrest { get; set; }


        [NotMapped]
        public List<GDXMLHEADER> Nfe { get; set; }

        [NotMapped]
        public List<GDCTENFE> ctenfe { get; set; }

        [NotMapped]
        [Display(Name = "Pedidos")]
        public List<INTEGRAPEDIDO> Pedidos { get; set; }
    }
}
