using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_Katanga.educ.Areas.PerformanceEleve.Models
{
    public class Epreuve
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string IdentifiantCours { get; set; }
        public string IdentifiantClasse { get; set; }
        public string MAtriculeEleve { get; set; }

        public string Description { get; set; }

        public int Total { get; set; }
        public double Cote { get; set; }

        public DateTime DateEpreuve { get; set; }
    }
}
