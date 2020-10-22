using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_Katanga.educ.Areas.SystemeEvaluation.Models
{
    public class Examen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        public string IdentifiantClasse { get; set; }

        public string Titre { get; set; }
        public string Description { get; set; }
        public string CodeAcces { get; set; }
        public string Serie { get; set; }

        public int NombreQuestions 
        {
            get
            {
                return Questions.Count;
            }
        }
        public double Total 
        {
            get
            {
                double point = 0;
                foreach (Question q in Questions)
                {
                    point = point + q.Total;
                }
                return point;
            }
        }
        public List<Question> Qtns
        { get
            {
                return (List<Question>)Questions;
            }
        }

        public ICollection<Question> Questions { get; set; }
    }
}
