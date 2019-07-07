using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
    public class TMOVRATCCU
    {
        public short CODCOLIGADA { get; set; }
        [Key]
        public int IDMOV { get; set; }
        public string CODCCUSTO { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public string HISTORICO { get; set; }
        public Nullable<decimal> PERCENTUAL { get; set; }
        public Nullable<int> IDPRJ { get; set; }
        public Nullable<int> IDTRF { get; set; }
        public string CODTBGRUPOORC { get; set; }
        public int IDMOVRATCCU { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }

        public virtual TMOV TMOV { get; set; }
    }
}
