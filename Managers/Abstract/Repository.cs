using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model.Abstract;
using Data.Concrete;


namespace Managers.Abstract
{
    public abstract class Repository<T>:IRepository<T> where T:EntityBase
    {
        ProfileContext _context;
        protected Repository(ProfileContext context)
        {
            _context = context;
        }

        public IQueryable<T> All()
        {
            return _context.Set<T>();
        }
        public void Save(T obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public T Get(long Id)
        {
            return null;
        }

        public void Dispose()
        {

        }

    }

}
