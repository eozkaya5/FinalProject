using Autofac;
using Business.Abstract;
using Business.ConCrete;
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
        }
    }
}
