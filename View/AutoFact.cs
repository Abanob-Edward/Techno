using Appliaction.Contract;
using Appliaction.Services;
using Autofac;
using Context;
using Infrastructure.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace View
{
    public class AutoFact
    {
        public static IContainer InJect()
        {
            var builder = new ContainerBuilder();
           // builder.RegisterType<Application>();
            builder.RegisterType<_Context>().As<_Context>();
            builder.RegisterType<StudentService>().As<IStudentService>();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>();

           return  builder.Build();
        }
    }
}
