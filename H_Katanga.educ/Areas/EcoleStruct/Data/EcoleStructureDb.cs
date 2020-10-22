using H_Katanga.educ.Areas.EcoleStruct.Models;
using Microsoft.EntityFrameworkCore;

namespace H_Katanga.educ.Areas.EcoleStruct.Data
{
    public class EcoleStructureDb : DbContext
    {
        public EcoleStructureDb(DbContextOptions<EcoleStructureDb> options) : base(options) { }

        public DbSet<Categorie> categories { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Directeur> Directeurs { get; set; }
        public DbSet<Ecole> Ecoles { get; set; }
        public DbSet<Eleve> Eleves { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<SousDivision> SousDivisions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
