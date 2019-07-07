using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
    public class TMOVCTB
    {
        public short CODCOLIGADA { get; set; }
        [Key]
        public int IDMOV { get; set; }
        public int IDOPERACAO { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }

        public virtual TMOV TMOV { get; set; }
    }
}
