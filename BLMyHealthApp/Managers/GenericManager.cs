﻿using BLMyHealthApp.Managers.Interfaces;
using MyHealthApp.Entities;
using MyHealthApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLMyHealthApp.Managers
{
    public class GenericManager<TEntity> : IGenericManager<TEntity>
        where TEntity : BaseEntity
    {
        internal readonly IGenericRepository<TEntity> _repository;

        public GenericManager(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual List<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public virtual void Delete(int id)
        {
            _repository.Delete(id);
        }

    }
}
