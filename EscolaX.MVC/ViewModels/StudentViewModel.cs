using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EscolaX.MVC.ViewModels
{
    public class StudentViewModel
    {
        [Key]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Phone { get; set; }

        public int UserId { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}