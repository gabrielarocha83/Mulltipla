using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.XML
{
    public class RMPEDIDOS
    {
        public int IDMOV { get; set; }
        public string NUMEROMOV { get; set; }
        public int CODCOLIGADA { get; set; }
        public string CODTMV { get; set; }
        public string INTEGRA { get; set; }

    }
    public class INTEGRAPEDIDO
    {       
        public int Id { get; set; }
        public string VALOR { get; set; }

    }
}
