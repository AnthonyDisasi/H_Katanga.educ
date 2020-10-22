using H_Katanga.educ.Areas.PerformanceEleve.Models;
using Microsoft.EntityFrameworkCore;

namespace H_Katanga.educ.Areas.PerformanceEleve.Data
{
    public class AppPerformanceEleve : DbContext
    {
        public AppPerformanceEleve(DbContextOptions<AppPerformanceEleve> options) : base(options) {  }

        public DbSet<Epreuve> Epreuves { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
