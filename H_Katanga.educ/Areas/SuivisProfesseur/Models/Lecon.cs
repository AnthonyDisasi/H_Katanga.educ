using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_Katanga.educ.Areas.SuivisProfesseur.Models
{
    public class Lecon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string IdentifiantCours { get; set; }
        public string MatriculeProfesseur { get; set; }

        public DateTime DateLecon { get; set; }
        public string Description { get; set; }

        public CotationProfesseur CotationProfesseur { get; set; }
    }
}
