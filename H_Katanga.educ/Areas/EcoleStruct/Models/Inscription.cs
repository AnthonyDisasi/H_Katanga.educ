using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.EcoleStruct.Models
{
    public class Inscription
    {
        public string ID { get; set; }
        public string EleveId { get; set; }

        public DateTime DateInscription { get; set; }
        public string AnneeScolaire { get; set; }

        public Eleve Eleve { get; set; }
    }
}
