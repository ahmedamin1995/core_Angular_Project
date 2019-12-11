using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CrudAngalurDemo.Repository
{
 public   interface IRepositoryGeneric<T_Entity> where T_Entity : class
    {
        IEnumerable<T_Entity> GetAllRecords();
        IQueryable<T_Entity> GetAllRecordsQueryable();
        int GetAllRecordCount();
        void AddRecord(T_Entity entity);
        void Update(int id, T_Entity entity);
        void UpdateByWhere(Expression<Func<T_Entity, bool>> WherePredict, Action<T_Entity> ForEachPredict);
        T_Entity GetFirstorDefault(int record);
        T_Entity GetFirstorDefaultByWhere(Expression<Func<T_Entity, bool>> WherePredict);

        void Remove(T_Entity entity);
        void RemoveByWhere(Expression<Func<T_Entity, bool>> WherePredict);
        void RemoveRange(Expression<Func<T_Entity, bool>> WherePredict);
        IEnumerable<T_Entity> GetList(Expression<Func<T_Entity, bool>> WherePredict);
        IEnumerable<T_Entity> GetRsultByStordProcedure(string query, object[] paramters);

        int SaveRecordChanges();


      
    }
}
