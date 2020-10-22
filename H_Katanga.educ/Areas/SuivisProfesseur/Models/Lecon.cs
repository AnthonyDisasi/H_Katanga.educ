using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.SuivisProfesseur.Models
{
    public class Lecon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string IdentifiantCours { get; set; }
        public string Matricule { get; set; }

        public DateTime DateLecon { get; set; }
        public string Description { get; set; }

        public CotationProfesseur CotationProfesseur { get; set; }
    }
}
