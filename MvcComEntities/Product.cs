using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcComEntities
{
    public class Product:BaseEntity
    {
        public Category category { get; set; }
        public decimal Price { get; set; }
        
    }
}
