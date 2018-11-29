using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Estudo.Models;

namespace Estudo.Context
{
    public class EstudoContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public EstudoContext()
            : base("Estudo")
        {
            
        }

    }
}