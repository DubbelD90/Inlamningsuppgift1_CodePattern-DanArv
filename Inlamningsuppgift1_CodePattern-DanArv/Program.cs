using Autofac;
using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using Inlamningsuppgift1_CodePattern_DanArv.Models;
using System;

namespace Inlamningsuppgift1_CodePattern_DanArv
{
    public class Program
    {

        static void Main(string[] args)
        {
            var container = AFConfig.Configure();


            using (var scope = container.BeginLifetimeScope())
            {
                var application = scope.Resolve<IApplication>();
                application.Run();
            }

        }
    }
}
