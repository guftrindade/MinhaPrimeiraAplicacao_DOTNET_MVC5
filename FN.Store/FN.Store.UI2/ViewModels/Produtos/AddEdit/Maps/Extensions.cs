using FN.Store.Domain.Entities;

namespace FN.Store.UI2.ViewModels.Produtos.AddEdit.Maps
{
    public static class Extensions
    {
        public static ProdutoAddEditVM ToProdutoAddEditVM(this Produto model)
        {
            return new ProdutoAddEditVM()
            {
                id = model.id,
                Nome = model.Nome,
                Preco = model.Preco,
                TipoDeProdutoId = model.TipoDeProdutoId,
                Qtde = model.Qtde,
                DataCadastro = model.DataCadastro
            };
        }

        public static Produto ToProduto(this ProdutoAddEditVM model)
        {
            return new Produto()
            {
                id = model.id,
                Nome = model.Nome,
                Preco = model.Preco,
                TipoDeProdutoId = model.TipoDeProdutoId,
                Qtde = model.Qtde,
                DataCadastro = model.DataCadastro
            };
        }
    }
}