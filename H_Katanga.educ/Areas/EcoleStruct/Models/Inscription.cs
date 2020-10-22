using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_Katanga.educ.Areas.EcoleStruct.Models
{
    public class Inscription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        public string EleveId { get; set; }
        public string ClasseID { get; set; }

        public DateTime DateInscription { get; set; }
        public string AnneeScolaire { get; set; }

        public Eleve Eleve { get; set; }
        public Classe Classe { get; set; }
    }
}
