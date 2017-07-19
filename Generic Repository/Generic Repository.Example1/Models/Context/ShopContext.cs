using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Repository.Example1.Models.Context
{
    class ShopContext : DbContext
    {
        public ShopContext() : base("name=test")
        {
        }

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Product> Products { get; set; }
    }
}
