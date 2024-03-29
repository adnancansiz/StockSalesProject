﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StockSalesProject.Business.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}