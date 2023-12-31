﻿using System.ComponentModel.DataAnnotations;

namespace API_Produtos.DAL.Entities
{
    public class Produto
    {
       
        [Key]
        public long IdProduto { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public float valor_unitario { get; set; }
        [Required]
        public int qtde_estoque { get; set; }
        public DateTime? DataUltimaVenda { get; set; }
        public int? ValorUltimaVenda { get; set; }

    }

}

