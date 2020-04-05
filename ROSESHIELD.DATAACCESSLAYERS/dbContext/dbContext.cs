using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DATAACCESSLAYERS.dbContext
{
    public class dbContext : DbContext
    {
        public dbContext() : base("name=dbLocal") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Cadastro> Cadastro { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<PreCadastroUsuario> PreCadastro { get; set; }
        public DbSet<EmpresaParceira> EmpresaParceira { get; set; }
        public DbSet<Ong> Ong { get; set; }
        public DbSet<PoliciaMilitarEntity> PoliciaMilitar { get; set; }
        public DbSet<ProfissionalDesconto> ProfissionalDesconto { get; set; }
        public DbSet<ProfissionalVoluntario> ProfissionalVoluntario { get; set; }
        public DbSet<Violencia> Violencia { get; set; }
        public DbSet<CadastroDeVitimas> CadastroDeVitimas { get; set; }

        public DbSet<CadastroFilho> CadastroFilho { get; set; }

        public DbSet<CadastroIdoso> CadastroIdoso { get; set; }

        public DbSet<CadastroSOS> CadastroSOS { get; set; }

        public DbSet<CadastroComplementar> CadastroComplementar { get; set; }

        public DbSet<ExcelImportado> ExcelImportado { get; set; }

        




    }
}
