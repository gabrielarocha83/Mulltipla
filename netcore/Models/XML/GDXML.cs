using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.XML
{
    public class GDXML
    {
        [Key]
        public int IDXML { get; set; }
        public string CHAVE { get; set; }
        public string XML { get; set; }
        public int STATUS { get; set; }
        public int INTEGRADO { get; set; }
        public System.DateTime DATAINCLUSAO { get; set; }
        public System.DateTime DATAINTEGRACAO { get; set; }
        public string CNPJEMIT { get; set; }
        public int TIPOIMPORTACAO { get; set; }
        public string CNPJDEST { get; set; }
        public Nullable<System.DateTime> DATAVALIDACAO { get; set; }
        public Nullable<int> CODCOLIGADA { get; set; }
        public Nullable<int> CODFILIAL { get; set; }
        public Nullable<int> IDMOV { get; set; }
        public string NUMEROMOV { get; set; }
        public string CODTMV { get; set; }
        public string CUF { get; set; }
        public string TIPOMOVIMENTO { get; set; }
        public Nullable<int> PROCESSADO { get; set; }
        public string NUMPEDIDO { get; set; }
        public string TIPOMA { get; set; }
    }
}
