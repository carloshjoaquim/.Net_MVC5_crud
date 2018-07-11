using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public String Nome { get; set; }

        public float Preco { get; set; }

        public CategoriaDoProduto Categoria { get; set; }

        [Range(1, int.MaxValue)]
        public int CategoriaId { get; set; }

        [MaxLength(150)]
        public String Descricao { get; set; }

        [Required, Range(1,int.MaxValue)]
        public int Quantidade { get; set; }
    }
}