using Generic_Repository.Example1.Models;
using Generic_Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Generic_Repository.Example1.Repository.Contracts;

namespace Generic_Repository.Example1.Repository
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
