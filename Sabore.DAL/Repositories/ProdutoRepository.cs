using Sabore.Models;

namespace Sabore.DAL.Repositories
{
    public class ProdutoRepository
    {
        public ProdutoRepository() { }

        public bool CadastrarProduto(Produto produto)
        {
            Console.WriteLine($"Produto cadastrado: {produto.Nome}");
            return true;
        }

        public List<Produto> ListarProdutos()
        {
            var lista = new List<Produto>()
           {
               new Produto()
               {
                     Guid = Guid.NewGuid(),
                     Id = 1,
                     Nome = "Produto 1",
                     Descricao = "Descricao do Produto 1",
                     Imagem = "imagem1.jpg",
                     PrecoCusto = 10.00m,
                     PrecoVenda = 15.00m,
                     Estoque = 100,
                     Desconto = 0.10f,
                     DataCadastro = DateTime.Now
               },
               new Produto()
               {
                     Guid = Guid.NewGuid(),
                     Id = 2,
                     Nome = "Produto 2",
                     Descricao = "Descricao do Produto 2",
                     Imagem = "imagem2.jpg",
                     PrecoCusto = 20.00m,
                     PrecoVenda = 25.00m,
                     Estoque = 200,
                     Desconto = 0.15f,
                     DataCadastro = DateTime.Now
               }
           };
            return lista;
        }
    }
}
