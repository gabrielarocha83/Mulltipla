using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.RM
{
   
        public  class CapexImport
        {
            [Key]
            public int Id { get; set; }
            public string ContaContabil { get; set; }
            public Nullable<double> Coligada { get; set; }
            public string ContaGerencial { get; set; }
            public string ColigadaGerencial { get; set; }
            public Nullable<double> Filial { get; set; }
            public string CentroCusto { get; set; }
            public string Departamento { get; set; }
            public Nullable<double> Ano { get; set; }
            public Nullable<double> ValorMes1 { get; set; }
            public Nullable<double> ValorMes2 { get; set; }
            public Nullable<double> ValorMes3 { get; set; }
            public Nullable<double> ValorMes4 { get; set; }
            public Nullable<double> ValorMes5 { get; set; }
            public Nullable<double> ValorMes6 { get; set; }
            public Nullable<double> ValorMes7 { get; set; }
            public Nullable<double> ValorMes8 { get; set; }
            public Nullable<double> ValorMes9 { get; set; }
            public Nullable<double> ValorMes10 { get; set; }
            public Nullable<double> ValorMes11 { get; set; }
            public Nullable<double> ValorMes12 { get; set; }
            public Nullable<double> Valor2Mes1 { get; set; }
            public Nullable<double> Valor2Mes2 { get; set; }
            public Nullable<double> Valor2Mes3 { get; set; }
            public Nullable<double> Valor2Mes4 { get; set; }
            public Nullable<double> Valor2Mes5 { get; set; }
            public Nullable<double> Valor2Mes6 { get; set; }
            public Nullable<double> Valor2Mes7 { get; set; }
            public Nullable<double> Valor2Mes8 { get; set; }
            public Nullable<double> Valor2Mes9 { get; set; }
            public Nullable<double> Valor2Mes10 { get; set; }
            public Nullable<double> Valor2Mes11 { get; set; }
            public Nullable<double> Valor2Mes12 { get; set; }
        }
    
}
