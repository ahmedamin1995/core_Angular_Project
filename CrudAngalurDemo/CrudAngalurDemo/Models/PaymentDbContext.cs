using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAngalurDemo.Models
{
    public class PaymentDbContext:DbContext
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options):base(options)
        {

        }

        public DbSet<PaymentDetails> paymentDetails { get; set; }
        public DbSet<Make> makes { get; set; }
        public DbSet<Model>  models { get; set; }
    }
}
