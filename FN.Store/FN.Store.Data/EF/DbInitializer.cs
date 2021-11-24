﻿using FN.Store.Domain.Entities;
using FN.Store.Domain.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace FN.Store.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<FNStoreDataContext>
    {
        protected override void Seed(FNStoreDataContext context)
        {
            var alimento = new TipoDeProduto() { Nome = "Alimento" };
            var higiene = new TipoDeProduto() { Nome = "Higiene" };
            var eletronico = new TipoDeProduto() { Nome = "Eletrônico" };
            var limpeza = new TipoDeProduto() { Nome = "Limpeza" };

            var produtos = new List<Produto>() {
                new Produto() { Nome = "Picanha", Preco = 70.5M, Qtde = 150, TipoDeProduto = alimento},
                new Produto() { Nome = "Alcatra", Preco = 55.20M, Qtde = 250, TipoDeProduto = alimento},
                new Produto() { Nome = "Pasta de Dente", Preco = 9.5M, Qtde = 250, TipoDeProduto = higiene},
                new Produto() { Nome = "Sabonete", Preco = 9.5M, Qtde = 250, TipoDeProduto = higiene},
                new Produto() { Nome = "Desinfetante", Preco = 8.99M, Qtde = 520,TipoDeProduto = limpeza},
                new Produto() { Nome = "Detergente", Preco = 2.99M, Qtde = 170,TipoDeProduto = limpeza},
                new Produto() { Nome = "Telefone sem fio", Preco = 125.15M, Qtde = 85, TipoDeProduto = eletronico}

            };
            context.Produtos.AddRange(produtos);

            context.Usuarios.Add(new Usuario()
            {
                Nome = "Gustavo Trindade",
                Email = "gustavo@gmail.com",
                Senha = "mudar123".Encrypt()
            });

            context.SaveChanges();
        }
    }
}
