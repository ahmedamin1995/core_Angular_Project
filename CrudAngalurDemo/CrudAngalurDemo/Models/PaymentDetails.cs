using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAngalurDemo.Models
{
    public class PaymentDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string OwnerName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string OwnerNumber { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string CVV { get; set; }
    }
}
