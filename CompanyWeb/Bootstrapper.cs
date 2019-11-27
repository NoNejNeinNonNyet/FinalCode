using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Repository.Interfaces;
using Repository.Repositories;
using Services.HttpProvider;
using Services.Interfaces;
using Services.Services;

namespace CompanyWeb
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            AutoFacConteinerBuilder();
        }

        public static void AutoFacConteinerBuilder()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //repositories
            var repositoryAssembly = Assembly.Load("Repository");
            builder.RegisterAssemblyTypes(repositoryAssembly)
                .Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces()
                .InstancePerRequest();

            //or this
            //builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerRequest();
            // builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerRequest();

            //services
            var serviceAssembly = Assembly.Load("Services");
            builder.RegisterAssemblyTypes(serviceAssembly)
                .Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces()
                .InstancePerRequest();

            builder.RegisterType<HttpProvider>().As<IHttpProvider>().InstancePerRequest();
            builder.RegisterType<HttpClient>().As<HttpClient>().InstancePerRequest();
            //or this
            // builder.RegisterType<ReportS>().As<IReportService>().InstancePerRequest();
            // builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerRequest();

            builder.RegisterFilterProvider();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}