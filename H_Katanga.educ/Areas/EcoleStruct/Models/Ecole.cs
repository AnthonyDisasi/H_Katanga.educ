using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.EcoleStruct.Models
{
    public class Ecole
    {
        public string ID { get; set; }
        public string DirecteurID { get; set; }

        [Display(Name = "Nom"), Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }

        public string EcoleLatitude { get; set; }
        public string EcoleLongitude { get; set; }

        [Display(Name = "Sous-division"), Required(ErrorMessage = "La sous division est obligatoire")]
        public string SousDivision { get; set; }

        public Directeur Directeur { get; set; }
        public ICollection<Classe> Classes { get; set; }
    }
}
