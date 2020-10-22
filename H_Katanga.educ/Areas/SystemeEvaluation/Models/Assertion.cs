using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H_Katanga.educ.Areas.SystemeEvaluation.Models
{
    public class Assertion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        public string QuestionID { get; set; }

        public string reponse { get; set; }
        public double Point { get; set; }

        public Question Question { get; set; }
    }
}
