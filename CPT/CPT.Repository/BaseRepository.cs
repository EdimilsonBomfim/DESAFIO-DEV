using CPT.Repository.Factories.Interfaces;
using CPT.Repository.Interface;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CPT.Repository
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private readonly IConnectionFactory _connectionFactory;
        protected readonly SqlConnection conn;

        public BaseRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            conn = _connectionFactory.Connection();
        }

        public void Delete(T obj)
        {
            conn.Delete(obj);
        }

        public void Dispose()
        {
            conn.Close();
            conn.Dispose();
            GC.SuppressFinalize(this);
        }

        public T Get(int id)
        {
            return conn.Get<T>(id);
        }

        public void Insert(T obj)
        {
            conn.Insert(obj);
        }

        public void Update(T obj)
        {
            conn.Update(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return conn.GetAll<T>();
        }
    }
}
