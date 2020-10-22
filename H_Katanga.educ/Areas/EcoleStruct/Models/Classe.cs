using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.EcoleStruct.Models
{
    public class Classe
    {
        public string ID { get; set; }
        public string EcoleID { get; set; }

        [Required(ErrorMessage = "Le niveau est obligatoire")]
        public string Niveau { get; set; }
        [Required(ErrorMessage = "La section est obligatoire")]
        public string Section { get; set; }
        public string Option { get; set; }

        public string NomComplet
        {
            get
            {
                return Niveau + " " + Section + " " + Option;
            }
        }

        public Ecole Ecole { get; set; }
        public ICollection<Cours> Cours { get; set; }
        public ICollection<Inscription> Inscriptions { get; set; }
    }
}
