﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tygre.Core.Entities;

namespace Tygre.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter = null);
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null);
        Task<bool> Add(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Update(T user);
    }
}
