using Appliaction.Contract;
using AutoMapper;
using Infrastructure.Contract;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public class CartService : ICartService
    {
        private readonly IMapper mapper;
        private readonly ICartRepository cartRepository;
        private readonly ICartproudectRepository cartproudectRepository;
        public CartService(ICartRepository _cartRepository, IMapper _mapper, ICartproudectRepository _cartproudect)
        {
            cartRepository = _cartRepository;
            cartproudectRepository = _cartproudect;
            mapper    =_mapper;
        }

        public int GetCartIdforCurrentUSer(int UserId)
        {
          return    cartRepository.GetCartByUserID(UserId).Id;
        }
       public IQueryable<ProductCartItem> GetAllProductInCartItems(int cartId)
        {
          return  cartproudectRepository.getAll().Where(c=>c.CartId == cartId).Include(p => p.Product);
        }
        
        public IQueryable<ProductCartItem> GetAllProductInCartItemsPaging(int skipCount, int takeCount, int cartId)
        {
          return  cartproudectRepository.getAll().Where(c=>c.CartId == cartId).Include(p => p.Product).Skip(skipCount).Take(takeCount);
        }
        public CartItem GetCartByUserID(int USerID)
        {
            return cartRepository.GetCartByUserID(USerID);
        }
        public CartItem addNewCart(int UserID)
        {
            CartItem cartItem = new CartItem() { User_Id = UserID, };
          return  cartRepository.add(cartItem);
            
        }

        public ProductCartItem addproductToCart(int ProID, int CartID)
        {

            // قبل ما يشيف ي شيك بال  productID and cartID  
            // عشان لو البرودكت مضاف قبل كدا يزود واحد ف الكونتيتي 
             (bool, ProductCartItem) result  = cartproudectRepository.CheckExeistProduct(ProID, CartID);

            if(result.Item1 == true)
            {
                result.Item2.Quantity += 1;
              return cartproudectRepository.update(result.Item2);
            }
            else
            {
                ProductCartItem productCart = new ProductCartItem() { CartId = CartID, Pro_Id = ProID ,Quantity=1};
                return cartproudectRepository.add(productCart);
            }



        }
    
       

        public void DeleteOneProductFromCart(int proID)
        {
            cartproudectRepository.DeleteOneProductFromCart(proID);
        }

        public void DeleteListOfProductFromCart(List<int> proIDs)
        {
            cartproudectRepository.DeleteProductFromCart(proIDs);
        }
    }
}
