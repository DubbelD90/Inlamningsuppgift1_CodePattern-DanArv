﻿using Autofac;
using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using Inlamningsuppgift1_CodePattern_DanArv.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv
{
    public static class AFConfig
    {
        public static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<CostOfServices>().As<ICostOfServices>();
            builder.RegisterType<CreateCustPetList>().As<ICreateCustPetList>();
            builder.RegisterType<Customer>();
            builder.RegisterType<GetPrice>().As<IGetPrice>();
            builder.RegisterType<KennelMannagement>().As<IKennelManagement>();
            builder.RegisterType<KennelServices>().As<IKennelServices>();
            builder.RegisterType<MainMenu>().As<IMainMenu>();
            builder.RegisterType<ManageCustomer>().As<IManageCustomer>();
            builder.RegisterType<ManagePet>().As<IManagePet>();
            builder.RegisterType<Pet>();


            return builder.Build();
        }
    }
}
