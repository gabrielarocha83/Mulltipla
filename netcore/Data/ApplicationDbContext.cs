using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MulltiplaJML.Models;
using MulltiplaJML.Models.Invent;
using MulltiplaJML.Models.Crm;
using MulltiplaJML.Models.XML;

namespace MulltiplaJML.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<MulltiplaJML.Models.ApplicationUser> ApplicationUser { get; set; }
        
        public DbSet<MulltiplaJML.Models.Invent.Branch> Branch { get; set; }

       

        public DbSet<MulltiplaJML.Models.Crm.Activity> Activity { get; set; }



        public DbSet<MulltiplaJML.Models.Crm.AccountExecutive> AccountExecutive { get; set; }


        public DbSet<MulltiplaJML.Models.DFe.ResNFe> Resnfe { get; set; }

        public DbSet<MulltiplaJML.Models.XML.GDXMLHEADER> GDXMLHEADER { get; set; }

        public DbSet<MulltiplaJML.Models.XML.GDXMLITENS> GDXMLITENS { get; set; }

        public DbSet<MulltiplaJML.Models.XML.GDXMLCTE> GDXMLCTE { get; set; }

        public DbSet<MulltiplaJML.Models.XML.GDXML> GDXML { get; set; }

        public DbSet<MulltiplaJML.Models.Invent.OrdemServico> OrdemServico { get; set; }

        public DbSet<MulltiplaJML.Models.Invent.ItensOrdemServico> ItensOrdemServico { get; set; }

        public DbSet<MulltiplaJML.Models.XML.GDCTENFE> GDCTENFE { get; set; }

        public DbSet<MulltiplaJML.Models.AccountViewModels.Usuarios> Usuarios { get; set; }
        public DbSet<MulltiplaJML.Models.AccountViewModels.UsuariosERP> UsuariosERP { get; set; }

        public DbSet<MulltiplaJML.Models.Compras> Compras { get; set; }

        public DbSet<MulltiplaJML.Models.ItensCompra> ItensCompra { get; set; }

        public DbSet<MulltiplaJML.Models.RequisicaoCompras> RequisicaoCompras { get; set; }

        public DbSet<MulltiplaJML.Models.ItensRequisicaoCompras> ItensRequisicaoCompras { get; set; }


        public DbSet<MulltiplaJML.Models.Pagamento> Pagamento { get; set; }

        public DbSet<MulltiplaJML.Models.CAPEX> CAPEX { get; set; }

        public DbSet<MulltiplaJML.Models.ItensCAPEX> ItensCAPEX { get; set; }


        public DbSet<MulltiplaJML.Models.RM.MatrizFilial> MatrizFilial { get; set; }

        public DbSet<MulltiplaJML.Models.PrazosEntrega> PrazosEntrega { get; set; }

        public DbSet<MulltiplaJML.Models.RM.Produto> Produto { get; set; }

        public DbSet<MulltiplaJML.Models.RM.CapexImport> CapexImport { get; set; }

    }
}
