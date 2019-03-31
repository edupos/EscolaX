using EscolaX.Domain.Interfaces.Repositories;
using EscolaX.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaX.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected EscolaXContext Db = new EscolaXContext();

        public void Add(T entity)
        {
            Db.Set<T>().Add(entity);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            Db.Set<T>().Remove(entity);
            Db.SaveChanges();
        }

        public void Update(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
