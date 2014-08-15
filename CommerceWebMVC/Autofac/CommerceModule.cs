﻿using Autofac;
using Ploeh.Samples.Commerce.Data.Sql;
using Ploeh.Samples.Commerce.Domain;
using Ploeh.Samples.Commerce.Web.PresentationModel.Controllers;
using System.Configuration;

namespace Ploeh.Samples.Commerce.Web.Autofac {
    public class CommerceModule : Module {
        protected override void Load(ContainerBuilder builder) {
            builder.RegisterAssemblyTypes(typeof(HomeController).Assembly)
                .AsSelf()
                .InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(BasketService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .SingleInstance();
            builder.RegisterAssemblyTypes(typeof(BasketDiscountPolicy).Assembly)
                .Where(t => t.Name.EndsWith("Policy"))
                .As(t => t.BaseType)
                .SingleInstance();

            string connectionString = ConfigurationManager.ConnectionStrings["CommerceObjectContext"].ConnectionString;
            var a = typeof(SqlProductRepository).Assembly;
            builder.RegisterAssemblyTypes(a)
                .Where(t => t.Name.StartsWith("Sql"))
                .As(t => t.BaseType)
                .InstancePerLifetimeScope()
                .WithParameter("connString", connectionString);
        }
    }
}
