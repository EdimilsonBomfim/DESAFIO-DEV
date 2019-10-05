using CPT.Business.Interface;
using CPT.Domain.Entidades;
using CPT.Services.Interfaces;
using System.Collections.Generic;

namespace CPT.Services
{
    public class ProdutoService : IProdutoServices
    {
        private readonly IProdutoBusiness _produtoBusiness;

        public ProdutoService(IProdutoBusiness produtoBusiness)
        {
            _produtoBusiness = produtoBusiness;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _produtoBusiness.GetAll();
        }

        public IEnumerable<Produto> GetByName(string nome)
        {
            return _produtoBusiness.GetByName(nome);
        }
    }
}
