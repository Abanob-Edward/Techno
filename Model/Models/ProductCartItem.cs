using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class ProductCartItem
    {
        public int ID { get; set; }

        public int Quantity { get; set; }
        [ForeignKey("Item")]
        public int? ItemID { get; set; }
        public Item? Item { get; set; }
        /*        public string? Color { get; set; }
                public float? Inch { get; set; }
                public int? Storge { get; set; }*/

        [ForeignKey("Product")]
        public int Pro_Id { get; set; }
        public Product Product { get; set; }

        [ForeignKey("CartItem")]
        public int CartId { get; set; }
        public virtual CartItem CartItem { get; set; }

    }
}
