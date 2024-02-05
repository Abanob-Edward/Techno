using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class ProductInOrder
    {

        public int ID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("item")]
        public int? item_ID { get; set; }
        public Item? item { get; set; }
        
        [ForeignKey("order")]
        public int OrderNumber { get; set; }
        public Order order { get; set; }

        [ForeignKey("Product")]
        public int product_Id { get; set; }
        public Product  Product { get; set; }
     




    }
}
