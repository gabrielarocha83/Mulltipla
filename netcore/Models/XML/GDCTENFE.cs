using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.XML
{
    public class GDCTENFE
    {
        [Key]
        public int id { get; set; }
        public string chCte { get; set; }
        public string chNfe { get; set; }
        public Nullable<int> Integrada { get; set; }
        public Nullable<int> Idmov { get; set; }
    }
}
