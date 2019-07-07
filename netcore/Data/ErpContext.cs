using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Data
{
    public class ErpContext : DbContext
    {
        public ErpContext(DbContextOptions<ErpContext> options)
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

        public DbSet<MulltiplaJML.Models.RM.TITMMOV> TITMMOV { get; set; }

        public DbSet<MulltiplaJML.Models.RM.TMOV> TMOV { get; set; }

        public DbSet<MulltiplaJML.Models.RM.TMOVCOMPL> TMOVCOMPL { get; set; }

        public DbSet<MulltiplaJML.Models.RM.TMOVCTB> TMOVCTB { get; set; }

        public DbSet<MulltiplaJML.Models.RM.TMOVRATCCU> TMOVRATCCU { get; set; }

        public DbSet<MulltiplaJML.Models.RM.TMOVRELAC> TMOVRELAC { get; set; }

        public DbSet<MulltiplaJML.Models.RM.FCFO> FCFO { get; set; }
    }
}
