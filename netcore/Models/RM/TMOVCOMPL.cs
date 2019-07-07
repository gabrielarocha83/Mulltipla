using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
    public class TMOVCOMPL
    {
        public short CODCOLIGADA { get; set; }
        [Key]
        public int IDMOV { get; set; }
        public string CCMBCO01 { get; set; }
        public string CCMBCO02 { get; set; }
        public string CCMBCO03 { get; set; }
        public string CCMBCO04 { get; set; }
        public string CCMBCO05 { get; set; }
        public string CCMREPRESENTANTE2 { get; set; }
        public Nullable<decimal> CCMCOMISSAO { get; set; }
        public string CCMOBSCI { get; set; }
        public string CCMBCO06 { get; set; }
        public string ETIQUETA { get; set; }
        public string CCMVINC { get; set; }
        public string DIVISAOCALCULADA { get; set; }
        public Nullable<decimal> DIVISAO { get; set; }
        public Nullable<System.DateTime> CCMPREVISAORETORNO { get; set; }
        public string LIBERACOM { get; set; }
        public string LIBERACOMISSAO { get; set; }
        public Nullable<System.DateTime> ENTREGUEEM { get; set; }
        public Nullable<System.DateTime> DTSAIDA { get; set; }
        public string BOX { get; set; }
        public string PRISMA { get; set; }
        public string SEPARADOR { get; set; }
        public string CONFERENTE { get; set; }
        public string INISEP { get; set; }
        public string FIMSEP { get; set; }
        public string CONFERENCIA { get; set; }
        public string OBSINT { get; set; }
        public string REFATURADO { get; set; }
        public string OCORRENCIA { get; set; }
        public string MOTDEVOLUC { get; set; }
        public string BCOCOMCOB { get; set; }
        public Nullable<System.DateTime> DTCONCLUSAO { get; set; }
        public Nullable<System.DateTime> DTABERTURA { get; set; }
        public Nullable<decimal> XDESC { get; set; }
        public Nullable<decimal> CUBAGEM { get; set; }
        public string HORAABREOC { get; set; }
        public string HORACONCOC { get; set; }
        public string OPLOG { get; set; }
        public string PEDOPLOG { get; set; }
        public string GUIASTEMITE { get; set; }
        public Nullable<int> MOTDESICMS { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
        public string DUPIMPRESSA { get; set; }
        public string CONTRATO { get; set; }

        public virtual TMOV TMOV { get; set; }
    }
}
