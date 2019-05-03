using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Managers.Abstract
{
    public interface IRepository<T> where T: EntityBase
    {
        IQueryable<T> All();
        void Save(T obj);
        T Get(long Id);
    }
}
