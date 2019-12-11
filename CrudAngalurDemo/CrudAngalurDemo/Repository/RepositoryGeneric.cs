using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CrudAngalurDemo.Repository
{
    public class RepositoryGeneric<T_Entity>  : IRepositoryGeneric<T_Entity> where T_Entity : class
    {
        public void AddRecord(T_Entity entity)
        {
            throw new NotImplementedException();
        }

        public int GetAllRecordCount()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_Entity> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T_Entity> GetAllRecordsQueryable()
        {
            throw new NotImplementedException();
        }

        public T_Entity GetFirstorDefault(int record)
        {
            throw new NotImplementedException();
        }

        public T_Entity GetFirstorDefaultByWhere(Expression<Func<T_Entity, bool>> WherePredict)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_Entity> GetList(Expression<Func<T_Entity, bool>> WherePredict)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_Entity> GetRsultByStordProcedure(string query, object[] paramters)
        {
            throw new NotImplementedException();
        }

        public void Remove(T_Entity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveByWhere(Expression<Func<T_Entity, bool>> WherePredict)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(Expression<Func<T_Entity, bool>> WherePredict)
        {
            throw new NotImplementedException();
        }

        public int SaveRecordChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T_Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, T_Entity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateByWhere(Expression<Func<T_Entity, bool>> WherePredict, Action<T_Entity> ForEachPredict)
        {
            throw new NotImplementedException();
        }
    }
}
