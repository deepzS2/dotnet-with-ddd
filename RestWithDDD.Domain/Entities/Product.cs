using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithDDD.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
