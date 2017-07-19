using Generic_Repository.Example1.Models;
using Generic_Repository.Example1.Models.Context;
using Generic_Repository.Example1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Repository.Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ShopContext();
            var Categories = new CategoryRepository(context);
            Categories.Add(new Category()
            {
                Name = "Category 1",
                Description = "Category 1"
            });

            context.SaveChanges();

            var category = Categories.GetAll().First();
            Console.WriteLine(string.Format("{0} - {1}", category.ID, category.Name));

            Categories.Remove(category.ID);
            context.SaveChanges();

            Console.WriteLine(Categories.GetAll().Count());
        }

    }
}
