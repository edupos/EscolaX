﻿using EscolaX.Domain.Interfaces.Repositories;
using EscolaX.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaX.Domain.Services
{
    public class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(T entity)
        {
            _repository.Remove(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
