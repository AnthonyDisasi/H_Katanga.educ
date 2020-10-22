using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.SuivisProfesseur.Models
{
    public class CotationProfesseur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int LeconID { get; set; }
        public int InspecteurID { get; set; }

        public int Total { get; set; }
        public double Cote { get; set; }
        public string Description { get; set; }

        public Lecon Lecon { get; set; }
        public Inspecteur Inspecteur { get; set; }
    }
}
