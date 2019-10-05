using CPT.Repository.Factories.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace CPT.Repository.Factories
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlConnection Connection()
        {
            return new SqlConnection(_configuration.GetConnectionString("SQLServerConnection"));
        }
    }
}
