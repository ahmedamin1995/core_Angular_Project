using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAngalurDemo.Models
{
    public class Make
    {
        public Make()
        {
            models = new Collection<Model>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model>models { get; set; }
    }
}
