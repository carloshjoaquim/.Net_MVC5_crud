using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace Estoque.Models
{
    [TableName("Produtos")]
    public class Produto
    {
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public String Nome { get; set; }

        public float Preco { get; set; }

        public CategoriaDoProduto Categoria { get; set; }

        public int? CategoriaId { get; set; }

        [MaxLength(150)]
        public String Descricao { get; set; }

        [Required, Range(1, 10000000)]
        public int Quantidade { get; set; }
    }
}