using Generic_Repository.Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Repository.Example1.Repository.Contracts
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
