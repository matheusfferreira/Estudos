using Backend.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class GenericRepository<T>:IDisposable where T: class
    {
        private GenericContext context;

        public GenericRepository()
        {
            context = new GenericContext();
        }

        public virtual void Add(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            //ou context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            //context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        public virtual T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual List<T> ListAll()
        {
            return context.Set<T>().ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
