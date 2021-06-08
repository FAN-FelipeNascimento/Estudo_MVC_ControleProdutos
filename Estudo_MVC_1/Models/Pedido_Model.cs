using System;
using System.ComponentModel.DataAnnotations;

namespace Estudo_MVC_1.Models
{
    public class Pedido_Model
    {
        [Key]
        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Id Pedido")]
        public string IdPedido { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Identificação do Produtos")]
        public int IdProdutos { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Qunatidade Produtos")]
        public int QtdProdutos { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Identificação do Cliemnte")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Valor")]
        public string Valor { get; set; }

        [Display(Name = "Desconto")]
        public string Desconto { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Valor Total")]
        public string ValorTotal { get; set; }
    }
}