using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
    public class TITMMOV
    {
        public short CODCOLIGADA { get; set; }
        [Key]
        public int IDMOV { get; set; }
        public int NSEQITMMOV { get; set; }
        public short NUMEROSEQUENCIAL { get; set; }
        public Nullable<int> IDPRD { get; set; }
        public string CODTIP { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public Nullable<decimal> PRECOUNITARIO { get; set; }
        public Nullable<decimal> PRECOTABELA { get; set; }
        public Nullable<decimal> PERCENTUALDESC { get; set; }
        public Nullable<decimal> VALORDESC { get; set; }
        public Nullable<decimal> PERCENTUALDESP { get; set; }
        public Nullable<decimal> VALORDESP { get; set; }
        public Nullable<System.DateTime> DATAEMISSAO { get; set; }
        public string CODMEN { get; set; }
        public Nullable<short> NUMEROTRIBUTOS { get; set; }
        public string CODTB1FAT { get; set; }
        public string CODTB2FAT { get; set; }
        public string CODTB3FAT { get; set; }
        public string CODTB4FAT { get; set; }
        public string CODTB5FAT { get; set; }
        public string CODTB1FLX { get; set; }
        public string CODTB2FLX { get; set; }
        public string CODTB3FLX { get; set; }
        public string CODTB4FLX { get; set; }
        public string CODTB5FLX { get; set; }
        public string CAMPOLIVRE { get; set; }
        public string CODUND { get; set; }
        public Nullable<decimal> QUANTIDADEARECEBER { get; set; }
        public string CODNAT { get; set; }
        public string CODCPG { get; set; }
        public Nullable<System.DateTime> DATAENTREGA { get; set; }
        public string PRATELEIRA { get; set; }
        public Nullable<int> IDCNT { get; set; }
        public Nullable<short> NSEQITMCNT { get; set; }
        public Nullable<decimal> DATAFATDEC { get; set; }
        public Nullable<System.DateTime> DATAINIFAT { get; set; }
        public Nullable<System.DateTime> DATAFIMFAT { get; set; }
        public Nullable<short> FLAGEFEITOSALDO { get; set; }
        public Nullable<decimal> VALORUNITARIO { get; set; }
        public Nullable<decimal> VALORFINANCEIRO { get; set; }
        public Nullable<short> IMPRIMEMOV { get; set; }
        public string CODCCUSTO { get; set; }
        public Nullable<short> FLAGREPASSE { get; set; }
        public Nullable<decimal> ALIQORDENACAO { get; set; }
        public Nullable<decimal> QUANTIDADEORIGINAL { get; set; }
        public Nullable<int> IDNAT { get; set; }
        public Nullable<short> FLAG { get; set; }
        public string CHAPA { get; set; }
        public Nullable<System.DateTime> INICIO { get; set; }
        public Nullable<System.DateTime> TERMINO { get; set; }
        public Nullable<System.DateTime> PREVINICIO { get; set; }
        public string STATUS { get; set; }
        public Nullable<short> BLOCK { get; set; }
        public Nullable<short> FLAGREFATURAMENTO { get; set; }
        public Nullable<int> IDCNTDESTINO { get; set; }
        public Nullable<short> NSEQITMCNTDEST { get; set; }
        public Nullable<decimal> FATORCONVUND { get; set; }
        public Nullable<int> IDPRJ { get; set; }
        public Nullable<int> IDTRF { get; set; }
        public Nullable<decimal> VALORTOTALITEM { get; set; }
        public string VALORCODIGOPRD { get; set; }
        public Nullable<short> TIPOCODIGOPRD { get; set; }
        public Nullable<decimal> QTDUNDPEDIDO { get; set; }
        public string TRIBUTACAOECF { get; set; }
        public Nullable<short> CODFILIAL { get; set; }
        public string CODDEPARTAMENTO { get; set; }
        public Nullable<int> IDPRDCOMPOSTO { get; set; }
        public Nullable<decimal> QUANTIDADESEPARADA { get; set; }
        public Nullable<decimal> PERCENTCOMISSAO { get; set; }
        public string INDICENCM { get; set; }
        public string NCM { get; set; }
        public string CODRPR { get; set; }
        public Nullable<decimal> COMISSAOREPRES { get; set; }
        public Nullable<short> NSEQITMCNTMEDICAO { get; set; }
        public Nullable<decimal> VALORESCRITURACAO { get; set; }
        public Nullable<decimal> VALORFINPEDIDO { get; set; }
        public Nullable<decimal> VALORFRETECTRC { get; set; }
        public Nullable<decimal> VALOROPFRM1 { get; set; }
        public Nullable<decimal> VALOROPFRM2 { get; set; }
        public string IDOBJOFICINA { get; set; }
        public Nullable<short> PRECOEDITADO { get; set; }
        public Nullable<short> QTDEVOLUMEUNITARIO { get; set; }
        public Nullable<int> IDGRD { get; set; }
        public string CODVEN1 { get; set; }
        public string CODLOCALBN { get; set; }
        public string REGISTROEXPORTACAO { get; set; }
        public Nullable<System.DateTime> DATARE { get; set; }
        public Nullable<short> PRECOTOTALEDITADO { get; set; }
        public string CST { get; set; }
        public Nullable<decimal> VALORDESCCONDICONALITM { get; set; }
        public Nullable<decimal> VALORDESPCONDICIONALITM { get; set; }
        public Nullable<System.DateTime> DATAORCAMENTO { get; set; }
        public string CODTBORCAMENTO { get; set; }
        public Nullable<decimal> RATEIOFRETE { get; set; }
        public Nullable<decimal> RATEIOSEGURO { get; set; }
        public Nullable<decimal> RATEIODESC { get; set; }
        public Nullable<decimal> RATEIODESP { get; set; }
        public Nullable<decimal> RATEIOEXTRA1 { get; set; }
        public Nullable<decimal> RATEIOEXTRA2 { get; set; }
        public Nullable<decimal> RATEIOFRETECTRC { get; set; }
        public Nullable<decimal> RATEIODEDMAT { get; set; }
        public Nullable<decimal> RATEIODEDSUB { get; set; }
        public Nullable<decimal> RATEIODEDOUT { get; set; }
        public Nullable<int> IDCLASSIFENERGIACOMUNIC { get; set; }
        public Nullable<decimal> VALORUNTORCAMENTO { get; set; }
        public Nullable<decimal> VALSERVICONFE { get; set; }
        public string CODLOC { get; set; }
        public Nullable<decimal> VALORBEM { get; set; }
        public Nullable<decimal> VALORLIQUIDO { get; set; }
        public string CODIGOCODIF { get; set; }
        public string CODMUNSERVICO { get; set; }
        public string CODETDMUNSERV { get; set; }
        public Nullable<decimal> RATEIOCCUSTODEPTO { get; set; }
        public Nullable<decimal> CUSTOREPOSICAO { get; set; }
        public Nullable<decimal> CUSTOREPOSICAOB { get; set; }
        public Nullable<decimal> VALORFINTERCEIROS { get; set; }
        public Nullable<decimal> VALORFINANCGERENCIAL { get; set; }
        public string CODIGOSERVICO { get; set; }
        public Nullable<decimal> VALORUNITGERENCIAL { get; set; }
        public string IDINTEGRACAO { get; set; }
        public Nullable<int> IDTABPRECO { get; set; }
        public Nullable<decimal> VALORBRUTOITEM { get; set; }
        public Nullable<decimal> VALORBRUTOITEMORIG { get; set; }
        public Nullable<short> CODCOLTBORCAMENTO { get; set; }
        public Nullable<int> CODPUBLIC { get; set; }
        public Nullable<decimal> QUANTIDADETOTAL { get; set; }
        public short PRODUTOSUBSTITUTO { get; set; }
        public string CODTBGRUPOORC { get; set; }
        public Nullable<int> PRECOUNITARIOSELEC { get; set; }
        public Nullable<decimal> VALORRATEIOLAN { get; set; }
        public string RECCREATEDBY { get; set; }
        public Nullable<System.DateTime> RECCREATEDON { get; set; }
        public string RECMODIFIEDBY { get; set; }
        public Nullable<System.DateTime> RECMODIFIEDON { get; set; }
        public Nullable<decimal> VALORRECEBIDOFATPARC { get; set; }
        public Nullable<decimal> VALORCONCLUIDO { get; set; }
        public Nullable<short> CONSIGNADO { get; set; }

        public virtual TMOV TMOV { get; set; }
    }
}
