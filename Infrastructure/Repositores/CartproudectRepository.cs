using Context;
using Infrastructure.Contract;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class CartproudectRepository: Repository<ProductCartItem, int> , ICartproudectRepository
    {
        private readonly _Context context;
        public CartproudectRepository(_Context _context) : base(_context)
        {
            this.context = _context;

        }

        public void DeleteProductFromCart(List<int> proids)
        {

           
           
           var listOfproductIdToDelete = context.ProductCartItems.Where(x=> proids.Contains(x.Pro_Id)).ToList();
         //  var listOfproductIdToDelete = context.ProductCartItems.Where(x => x.Pro_Id == proid).ToList();
            foreach (var product in listOfproductIdToDelete)
            {
                context.ProductCartItems.Remove(product);
                context.SaveChanges();
            }
           
        }
        public void DeleteOneProductFromCart(int proid)
        {

            var product = context.ProductCartItems.FirstOrDefault(x => x.Pro_Id == proid);
            if(product != null) {
                context.ProductCartItems.Remove(product);
                context.SaveChanges();
            }
         

        }
        public (bool, ProductCartItem) CheckExeistProduct(int proID, int CartID)
        {
            
           var res = context.ProductCartItems.FirstOrDefault(x=>x.Pro_Id == proID  &&  x.CartId==CartID);

            if ( res != null) {
              return (true,res);
            }else
                return (false,null);

        }
    }
}
