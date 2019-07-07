using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
    public class TMOVRELAC
    {
        [Key]
        public int IDMOVORIGEM { get; set; }
        public short CODCOLORIGEM { get; set; }
        public int IDMOVDESTINO { get; set; }
        public short CODCOLDESTINO { get; set; }
        public string TIPORELAC { get; set; }
        public Nullable<int> IDPROCESSO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
        public Nullable<decimal> VALORRECEBIDO { get; set; }

    }
}
