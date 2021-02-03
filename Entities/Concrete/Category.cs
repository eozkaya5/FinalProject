using Entiteies.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entiteies.Concrete
{
    
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
