using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public abstract class Person
    {
        public int ID { get; set; }

        [Required]
        //Limite de caracteres
        [StringLength(50)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        //campo obligatorio
        [Required]
        //limite de caracteres
        [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres.")]
        [Column("FirstName")]
        [Display(Name = "Nombre")]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}