using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_Katanga.educ.Areas.EcoleStruct.Models
{
    public class Cours
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        public string ClasseID { get; set; }

        public string Intituler { get; set; }
        public string Categorie { get; set; }

        public Classe Classe { get; set; }
    }
}
