
using AutoMapper;
using DTOs.Orders;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Mapper
{
    public class _Mapper: Profile
    {
        public _Mapper()
        {
          CreateMap<orderProductDTO ,ProductInOrder>().ReverseMap();
        }

       
    }
}
