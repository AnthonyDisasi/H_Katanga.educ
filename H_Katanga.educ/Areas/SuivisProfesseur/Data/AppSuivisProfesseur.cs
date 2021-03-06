﻿using H_Katanga.educ.Areas.SuivisProfesseur.Models;
using Microsoft.EntityFrameworkCore;

namespace H_Katanga.educ.Areas.SuivisProfesseur.Data
{
    public class AppSuivisProfesseur : DbContext
    {
        public AppSuivisProfesseur(DbContextOptions<AppSuivisProfesseur> options) : base (options) { }

        public DbSet<CotationProfesseur> CotationProfesseurs { get; set; }
        public DbSet<Inspecteur> Inspecteurs { get; set; }
        public DbSet<Lecon> Lecons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
