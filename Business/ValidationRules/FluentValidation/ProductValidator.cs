using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(2);//en az iki harf olmalı
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);//sıfırdan büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p=>p.CategoryId==1);//içecekler ise 10 dan büyük olmalı
            RuleFor(p => p.ProductName).Must(StartWitA);//Kendi koşulunu oluştur




        }

        private bool StartWitA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
