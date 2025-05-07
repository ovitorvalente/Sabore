using Sabore.DAL.Repositories;
using Sabore.Models;

namespace Sabore.BLL
{
    public class ProdutoService
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        public bool CadastrarProduto(Produto produto)
        {
            var result = _produtoRepository.CadastrarProduto(produto);
            return result;
        }

        public List<Produto> ListarProdutos()
        {
            var ListaProdutos = _produtoRepository.ListarProdutos();
            return ListaProdutos;
        }
    }
}
