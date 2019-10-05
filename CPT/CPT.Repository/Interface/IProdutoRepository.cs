using CPT.Domain.Entidades;
using System.Collections.Generic;

namespace CPT.Repository.Interface
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        IEnumerable<Produto> GetByName(string nome);
    }
}
