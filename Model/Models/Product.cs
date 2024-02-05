using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public int Code { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
        [MaxLength(300)]

        public string Description { get; set; }
        public string Image { get; set; }
       /* public int Cat_id { get; set; }*/

        // one to many with user 
        [ForeignKey("User")]
        public int? AdminID { get; set; }
        public User User { get; set; }

        // one to many with user 
        [ForeignKey("category")]
        public int? CatID { get; set; }
        public Category category { get; set; }


        public ICollection<ProductInOrder> ProductInOrders { get; set; }
        public ICollection<Item> items { get; set; }
        public ICollection<ProductCartItem> productCartItems { get;}


    }
}
