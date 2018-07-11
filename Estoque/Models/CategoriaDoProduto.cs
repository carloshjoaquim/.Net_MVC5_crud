using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Estoque.Models
{
    [Table("CategoriaDoProduto")]
    public class CategoriaDoProduto
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }
    }
}