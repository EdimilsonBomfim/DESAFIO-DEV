using CPT.Domain.Entidades;
using System.Collections.Generic;

namespace CPT.Services.Interfaces
{
    public interface IProdutoServices
    {
        IEnumerable<Produto> GetAll();
        IEnumerable<Produto> GetByName(string nome);
    }
}
