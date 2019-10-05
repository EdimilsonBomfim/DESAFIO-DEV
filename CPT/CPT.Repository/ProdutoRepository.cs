using CPT.Domain.Entidades;
using CPT.Repository.Factories.Interfaces;
using CPT.Repository.Interface;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace CPT.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(IConnectionFactory connectionFactory) 
            : base(connectionFactory)
        {
        }

        public IEnumerable<Produto> GetByName(string nome)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Nome", nome, DbType.String);

            return conn.Query<Produto>(" SELECT * " +
                "                          FROM Produtos " +
                "                         WHERE Nome like CONCAT('%', @Nome, '%') ",
                parameters);
        }
    }
}
