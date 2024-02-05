using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Contract
{
    public interface ICartRepository : IG_Repo<CartItem, int>
    {

        CartItem GetCartByUserID(int USerID);
    }
}
