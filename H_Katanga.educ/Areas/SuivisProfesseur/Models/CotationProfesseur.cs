using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_Katanga.educ.Areas.SuivisProfesseur.Models
{
    public class CotationProfesseur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int LeconID { get; set; }
        public int MatriculeInspecteur { get; set; }

        public int Total { get; set; }
        public double Cote { get; set; }
        public string Description { get; set; }

        public Lecon Lecon { get; set; }
        public Inspecteur Inspecteur { get; set; }
    }
}
