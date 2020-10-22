using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.SuivisProfesseur.Models
{
    public class Professeur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Nomcomplet { get; set; }
        public string Matricule { get; set; }

        public ICollection<Lecon> Lecons { get; set; }
    }
}
