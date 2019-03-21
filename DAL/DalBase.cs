using DAL.DbClassContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalBase
    {
        internal EntityClassContext context = new EntityClassContext();

        public virtual int Add<T>(T model) where T : class
        {
            this.context.Entry(model).State = System.Data.Entity.EntityState.Added;
            return this.context.SaveChanges();
        }

        public int Delete<T>(T model) where T : class
        {
            this.context.Entry(model).State = System.Data.Entity.EntityState.Deleted;
            return this.context.SaveChanges();
        }

        public int Update<T>(T model) where T : class
        {
            this.context.Entry(model).State = System.Data.Entity.EntityState.Modified;
            return this.context.SaveChanges();
        }

        public List<T> Select<T>() where T : class
        {
            return this.context.Set<T>().ToList();
        }


    }
}
