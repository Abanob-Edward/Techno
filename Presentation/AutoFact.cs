using Appliaction.Contract;
using Appliaction.Mapper;
using Appliaction.Services;
using Autofac;
using AutoMapper;
using Context;
using Infrastructure.Contract;
using Infrastructure.Repositores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContainer = Autofac.IContainer;

namespace Presentation
{
    public class AutoFact
    {
        public static IContainer Inject()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<CatgoryRepositry>().As<ICategoryRepository>();

            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProudectRepository>().As<IProudectRepository>();

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
           
            builder.RegisterType<CartService>().As<ICartService>();
            builder.RegisterType<CartRepository>().As<ICartRepository>();
            builder.RegisterType<CartproudectRepository>().As<ICartproudectRepository>();

            builder.RegisterType<OrderService>().As<IOrderService>().InstancePerLifetimeScope();
           // builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<OrderProductRepository>().As<IOrderProductRepository>();

            

            builder.RegisterType<_Context>().As<_Context>();


            builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<_Mapper>();
            })).AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                   .As<IMapper>()
                   .InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}
