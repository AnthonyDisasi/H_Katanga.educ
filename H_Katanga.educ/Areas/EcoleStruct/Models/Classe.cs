using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_Katanga.educ.Areas.EcoleStruct.Models
{
    public class Classe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        public List<Eleve> ListEleve
        {
            get
            {
                List<Eleve> eleves = null;
                foreach(Inscription el in Inscriptions)
                {
                    eleves.Add(el.Eleve);
                }
                return eleves;
            }
        }

        public Ecole Ecole { get; set; }
        public ICollection<Cours> Cours { get; set; }
        public ICollection<Inscription> Inscriptions { get; set; }
    }
}
