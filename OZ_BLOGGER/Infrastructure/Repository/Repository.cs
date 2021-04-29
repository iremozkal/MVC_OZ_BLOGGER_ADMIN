using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using OZ_BLOGGER.Infrastructure.Context;
using System.Data.Entity;

namespace OZ_BLOGGER.Infrastructure.Repository
{
    public class Repository<T> : IRepo<T> where T : class
    {
        private readonly BlogContext context;
        private readonly DbSet<T> table;

        public Repository()
        {
            context = new BlogContext();
            table = context.Set<T>();
        }

        public T GetById(int Id)
        {
            return table.Find(Id);
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public bool Add(T Entity)
        {
            table.Add(Entity);

            if (context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(T Entity)
        {
            table.Attach(Entity);
            context.Entry(Entity).State = EntityState.Modified;

            if (context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(T Entity)
        {
            table.Remove(Entity);

            if (context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<T> SearchByQuery(Expression<Func<T, bool>> query)
        {
            return table.Where(query).ToList();
        }
    }
}