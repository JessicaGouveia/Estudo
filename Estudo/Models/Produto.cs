using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estudo.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public decimal Preco { get; set; }
    }
}