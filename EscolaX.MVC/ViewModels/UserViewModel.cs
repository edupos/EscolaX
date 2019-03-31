using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EscolaX.MVC.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Email { get; set; }

        public string Password { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string SecurityQuestion { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string SecurityAnswer { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime IncludeDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastLogin { get; set; }
    }
}