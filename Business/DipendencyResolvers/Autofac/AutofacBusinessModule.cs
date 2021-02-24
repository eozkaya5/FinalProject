using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.ConCrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DipendencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Strartup' yapılan SingleInstance yapısının karşılığıdır.
            // Autofac bize Aop desteği verir
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();// ProductManger istendiğinde IProductService' yi ver
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<IProductDal>().SingleInstance();

            //builder.RegisterType<FileLogger>().As<ILogger>().SingleInstance();//eğer logger isterse arka planda FileLogger ver.

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
    }

