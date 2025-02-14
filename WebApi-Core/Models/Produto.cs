﻿using Dapper.Contrib.Extensions;
using System;

namespace WebApi_Core.Models
{
    [Table("dbo.Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public int TipoProdutoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}