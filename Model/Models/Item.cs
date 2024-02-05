using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Item
    {
        public int Id { get; set; }

        public int Quantity { get; set; }
        public string? Color { get; set; }
        public float?  Inch  { get; set; }
        public int? Storge  { get; set; }

        [ForeignKey("Product")]
        public int Pro_Id { get; set; }
        public Product Product { get; set; }


    }
}
