﻿using H_Katanga.educ.Enumerations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_Katanga.educ.Areas.EcoleStruct.Models
{
    public class Professeur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        public string EcoleID { get; set; }

        [Required(ErrorMessage = "Le Nom est obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le Postnom est obligatoire")]
        public string Postnom { get; set; }
        [Required(ErrorMessage = "Le Prenom est obligatoire")]
        public string Prenom { get; set; }
        [EnumDataType(typeof(Genre))]
        public Genre? Genre { get; set; }
        [Required(ErrorMessage = "Le matricule est obligatoire")]
        public string Matricule { get; set; }
        public string Email { get; set; }

        [Display(Name = "Date de naissance"), Required(ErrorMessage = "La date de naissance est obligatoire")]
        public DateTime DateNaissance { get; set; }

        public string NomComplet
        {
            get
            {
                return Nom + " " + Postnom + " " + Prenom;
            }
        }
        public Ecole Ecole { get; set; }
    }
}
