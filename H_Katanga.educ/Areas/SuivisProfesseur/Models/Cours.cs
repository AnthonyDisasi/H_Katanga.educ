using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.SuivisProfesseur.Models
{
    public class Cours
    {
        public int ID { get; set; }
        public string Intituler { get; set; }

        public ICollection<Lecon> Lecons { get; set; }
    }
}
