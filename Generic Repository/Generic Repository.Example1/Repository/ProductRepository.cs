using Generic_Repository.Example1.Models;
using Generic_Repository.Example1.Repository.Contracts;
using Generic_Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Generic_Repository.Example1.Repository
{
    class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }
    }
}
