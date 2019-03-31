using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaX.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T :class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Dispose();
    }
}
