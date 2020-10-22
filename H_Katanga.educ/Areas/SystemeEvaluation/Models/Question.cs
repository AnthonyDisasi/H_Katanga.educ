using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.SystemeEvaluation.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Enoncer { get; set; }
        public string Solution { get; set; }

        public double Total
        {
            get
            {
                double totaux = 0;
                foreach (Assertion point in Assertions)
                {
                    totaux = totaux + point.Point;
                }
                return totaux;
            }
        }
        public ICollection<Assertion> Assertions { get; set; }
    }
}
