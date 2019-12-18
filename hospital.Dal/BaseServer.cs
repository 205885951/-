using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using  SqlSugar;
namespace hospital.Dal
{
    public class BaseServer<T> : IDAl.IBaseServer<T> where T : Models.BaseModels, new()
    {
        private readonly Models.DbContext Db;

        public BaseServer(Models.DbContext db)
        {
            Db = db;
        }
        public async Task Add(T t)
        {
            Db.Db.Insertable<T>(t).AddQueue();
          await  Db.Db.SaveQueuesAsync();
        }

        public List<T> All()
        {
            return Db.Db.Queryable<T>().ToList();
        }

        public List<T> AllWeher(Expression<Func<T, bool>> expression)
        {
            return Db.Db.Queryable<T>().Where(expression).ToList();
        }
        public List<T> AllWeherOrderBy(Expression<Func<T, bool>> expression)
        {
            return Db.Db.Queryable<T>().Where(expression).OrderBy(expression.ToString()).ToList();
        }
        public async  Task Rome(T t)
        {
            Db.Db.Deleteable<T>(t).AddQueue();
           await Db.Db.SaveQueuesAsync();
        }

        public async Task Update(T t)
        {
            Db.Db.Updateable(t).AddQueue();
           await Db.Db.SaveQueuesAsync();
        }

    }
}
