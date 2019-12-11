using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CrudAngalurDemo.Models;

namespace CrudAngalurDemo.Repository
{
    public class PaymentRepository : RepositoryGeneric<PaymentDetails>, IPaymentRepository
    {
        private PaymentDbContext _paymentDbContext;

        public PaymentRepository(PaymentDbContext paymentDbContext)
        {
            _paymentDbContext = paymentDbContext;
        }

        public int SaveRecordChanges()
        {
          return _paymentDbContext.SaveChanges();
        }

        public void AddRecord(PaymentDetails entity)
        {
            _paymentDbContext.Add(entity);
            SaveRecordChanges();
        }

        public int GetAllRecordCount()
        {
           return _paymentDbContext.paymentDetails.Count<PaymentDetails>();
        }

        public IEnumerable<PaymentDetails> GetAllRecords()
        {
            return _paymentDbContext.paymentDetails.ToList<PaymentDetails>();
        }

        public IQueryable<PaymentDetails> GetAllRecordsQueryable()
        {
            return _paymentDbContext.paymentDetails;
        }

        public PaymentDetails GetFirstorDefault(int record)
        {
            return _paymentDbContext.paymentDetails.FirstOrDefault<PaymentDetails>(p => p.Id == record);
        }

        public PaymentDetails GetFirstorDefaultByWhere(Expression<Func<PaymentDetails, bool>> WherePredict)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentDetails> GetList(Expression<Func<PaymentDetails, bool>> WherePredict)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentDetails> GetRsultByStordProcedure(string query, object[] paramters)
        {
            throw new NotImplementedException();
        }

        public void Remove(PaymentDetails entity)
        {
            _paymentDbContext.Remove(entity);
            SaveRecordChanges();
        }

        public void RemoveByWhere(Expression<Func<PaymentDetails, bool>> WherePredict)
        {
            
        }

        public void RemoveRange(Expression<Func<PaymentDetails, bool>> WherePredict)
        {
            throw new NotImplementedException();
        }

        public void Update(int id , PaymentDetails entity)
        {
          var oldData=  _paymentDbContext.paymentDetails.FirstOrDefault<PaymentDetails>(p => p.Id == id);
            oldData.OwnerName = entity.OwnerName;
            oldData.OwnerNumber = entity.OwnerNumber;
            oldData.Date = entity.Date;
            oldData.CVV = entity.CVV;



            SaveRecordChanges();
        }

        public void UpdateByWhere(Expression<Func<PaymentDetails, bool>> WherePredict, Action<PaymentDetails> ForEachPredict)
        {
            throw new NotImplementedException();
        }
    }
}
