using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OZ_BLOGGER.Infrastructure.Repository
{
    interface IRepo<T> where T : class
    {
        T GetById(int Id);
        List<T> GetAll();
        bool Add(T Entity);
        bool Update(T Entity);
        bool Delete(T Entity);
        List<T> SearchByQuery(Expression<Func<T, bool>> query);
    }
}
