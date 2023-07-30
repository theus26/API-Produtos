﻿using API_Produtos.DAL.Entities;
using API_Produtos.DTO;

namespace API_Produtos.Manager.Interfaces
{
    public interface IProdutosValidate
    {
        bool Validate(ProdutosDTO produtos);
        List<Produto> GetAll();
    }
}
