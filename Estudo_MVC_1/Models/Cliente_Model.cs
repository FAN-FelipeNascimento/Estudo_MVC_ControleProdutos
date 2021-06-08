using System;
using System.ComponentModel.DataAnnotations;

namespace Estudo_MVC_1.Models
{
    public class Cliente_Model
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Nome")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "E-mail")]
        public string EmailCliente { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Aldeia(clã)")]
        public string AldeiaCliente { get; set; }
    }
}