using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.XML
{
    public class GDINFOCTE
    {
        [Key]
        public int id { get; set; }
        public string chCte { get; set; }
        public Nullable<decimal> vCarga { get; set; }
        public string proPred { get; set; }
        public string xOutCat { get; set; }
        public string cUnid { get; set; }
        public string tpMed { get; set; }
        public Nullable<decimal> qCarga { get; set; }
        public string chave { get; set; }
        public Nullable<int> respSeg { get; set; }
        public string xSeg { get; set; }
        public string nApol { get; set; }
        public string RNTRC { get; set; }
        public Nullable<System.DateTime> dPrev { get; set; }
        public Nullable<int> lota { get; set; }

       

    }
}
