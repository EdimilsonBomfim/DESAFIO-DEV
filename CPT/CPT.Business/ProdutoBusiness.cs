using CPT.Business.Interface;
using CPT.Domain.Entidades;
using CPT.Repository.Interface;
using System.Collections.Generic;

namespace CPT.Business
{
    public class ProdutoBusiness : IProdutoBusiness
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoBusiness(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }

        public IEnumerable<Produto> GetByName(string nome)
        {
            return _produtoRepository.GetByName(nome);
        }
    }
}
