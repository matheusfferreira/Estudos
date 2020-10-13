using Backend.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    class GenericRepository<T>:IDisposable where T: class
    {
        private GenericContext context;

        public GenericRepository()
        {
            context = new GenericContext();
        }

        public void Add(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            //ou context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            //context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
