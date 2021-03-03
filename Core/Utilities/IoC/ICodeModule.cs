using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
   public interface ICodeModule
    {
        void Load(IServiceCollection serviceCollection);// sevis yükleme
    }
}
