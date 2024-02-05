using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public interface ICartService 
    {
        IQueryable<ProductCartItem> GetAllProductInCartItems(int cartId);
        public IQueryable<ProductCartItem> GetAllProductInCartItemsPaging(int skipCount, int takeCount, int cartId);

        int GetCartIdforCurrentUSer (int UserId);
        void DeleteOneProductFromCart(int proID);
        void DeleteListOfProductFromCart(List<int> proIDs);
        CartItem addNewCart(int UserID);
        CartItem GetCartByUserID(int USerID);
        ProductCartItem addproductToCart(int ProID,int CartID );

        
    }
}
