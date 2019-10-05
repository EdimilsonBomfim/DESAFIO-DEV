using System.Data.SqlClient;

namespace CPT.Repository.Factories.Interfaces
{
    public interface IConnectionFactory
    {
        SqlConnection Connection();
    }
}
