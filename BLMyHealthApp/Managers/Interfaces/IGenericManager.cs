﻿using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLMyHealthApp.Managers.Interfaces
{
    public interface IGenericManager<TEntity>
        where TEntity : BaseEntity
    {
        List<TEntity> GetAll();

        TEntity GetById(int id);

        int Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(int id);
    }
}
