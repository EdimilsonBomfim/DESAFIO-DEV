using System.Collections.Generic;

namespace CPT.Repository.Interface
{
    public interface IBaseRepository<T>
    {
        T Get(int Id);

        IEnumerable<T> GetAll();

        void Insert(T obj);

        void Update(T obj);

        void Delete(T obj);

    }
}
