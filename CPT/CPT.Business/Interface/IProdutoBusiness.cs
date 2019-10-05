using CPT.Domain.Entidades;
using System.Collections.Generic;

namespace CPT.Business.Interface
{
    public interface IProdutoBusiness 
    {
        IEnumerable<Produto> GetAll();
        IEnumerable<Produto> GetByName(string nome);
    }
}
