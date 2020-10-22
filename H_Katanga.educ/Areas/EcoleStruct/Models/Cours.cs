using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.EcoleStruct.Models
{
    public class Cours
    {
        public string ID { get; set; }
        public string ClasseID { get; set; }

        public string Intituler { get; set; }
        public string Categorie { get; set; }

        public Classe Classe { get; set; }
    }
}
