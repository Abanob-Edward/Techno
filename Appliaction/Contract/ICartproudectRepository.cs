using Appliaction.Contract;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contract
{
    public interface ICartproudectRepository: IG_Repo<ProductCartItem, int>
    {
        public (bool, ProductCartItem) CheckExeistProduct(int proID, int CartID);
        public void DeleteProductFromCart(List<int> proids);
        public void DeleteOneProductFromCart(int proid);
    }
}
