using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Order
    {

        public int Id { get; set; }

          public DateTime  OrderDate    { get; set; }
         public OrderStatus OrderStatus { get; set; }
        public decimal totalprice { get; set; }

        public ICollection<ProductInOrder> ProductInOrders { get; set; }
        [ForeignKey("User")]
        public int? User_ID { get; set; }
        public User? User { get; set; }
    }

    //[NotMapped]
   public  enum OrderStatus
    {
        processing=0,
        shipped=1, 
        delivered=2,
    }
}
