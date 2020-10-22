using H_Katanga.educ.Areas.SystemeEvaluation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.SystemeEvaluation.Data
{
    public class AppEvaluation : DbContext
    {
        public AppEvaluation(DbContextOptions<AppEvaluation> options) : base(options) { }

        public DbSet<Examen> Examens { get; set; }
        public DbSet<Assertion> Assertions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Serie> Series { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
