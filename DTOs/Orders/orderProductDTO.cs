using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Orders
{
    public class orderProductDTO
    {
        public int OrderNumber { get; set; }
        public int product_Id { get; set; }
        public int Quantity { get; set; }
    }
}
