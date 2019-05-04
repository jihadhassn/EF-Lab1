using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF.Repository
{
  public  interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
       TEntity GetById(params object[] id);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
       TEntity Add(TEntity entity);
    }
}
