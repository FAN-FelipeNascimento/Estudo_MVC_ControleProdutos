using System;
using System.ComponentModel.DataAnnotations;

namespace Estudo_MVC_1.Models
{
    public class Produto_Model
    {
        [Key]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [Display(Name = "Descrição")]
        public string DescricaoProduto { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário!")]
        [MinLength(1, ErrorMessage = "Valor inválido")]
        [Display(Name = "Valor")]
        public double ValorProduto { get; set; }

        [Display(Name = "Foto do Produto")]
        public byte[] FotoProduto { get; set; }
    }
}