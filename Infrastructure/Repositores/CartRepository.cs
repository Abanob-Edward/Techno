using Appliaction.Contract;
using Context;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{
    public class CartRepository :Repository<CartItem, int> , ICartRepository
    {

        private readonly _Context context;
        public CartRepository(_Context _context) : base(_context)
        {
            this.context = _context;

        }
        public CartItem GetCartByUserID(int USerID)
        {
            return context.CartItems.FirstOrDefault(c => c.User_Id == USerID);
        }

    }
}
