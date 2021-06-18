using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Util
{
    public class AutofacConfig
    {
       public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Naturalsmembers>().As<IMember>();
            return builder.Build();
        }
    }
}
