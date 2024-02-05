using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Category
    {
        [Key] 
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

        public ICollection<Product> Products { get; set; }

       
    }
}
