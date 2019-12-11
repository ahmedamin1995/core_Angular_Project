using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudAngalurDemo.Models;
using CrudAngalurDemo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrudAngalurDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private IPaymentRepository _paymentRepository;
        
        public PaymentController(IPaymentRepository paymentRepository )
        {
            _paymentRepository = paymentRepository;
        }
        // GET: api/Payment
        [HttpGet]
        public  IEnumerable<PaymentDetails> GetAll()
        {
            return _paymentRepository.GetAllRecords();
        }

        // GET: api/Payment/5
        [HttpGet("{id}", Name = "Get")]
        public PaymentDetails Get(int id)
        {
            return _paymentRepository.GetFirstorDefault(id);
        }

        // POST: api/Payment
        [HttpPost]
        public void Post([FromBody] PaymentDetails paymentDetails)
        {
            //var data = JsonConvert.DeserializeObject<PaymentDetails>(paymentDetails.ToString());
            _paymentRepository.AddRecord(paymentDetails);
        }

        // PUT: api/Payment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PaymentDetails newpaymentDetails)
        {
         

            _paymentRepository.Update(id,newpaymentDetails);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var paymentDetails = _paymentRepository.GetFirstorDefault(id);
            _paymentRepository.Remove(paymentDetails);
        }
    }
}
