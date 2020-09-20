using MvcComDatabase;
using MvcComEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcComServices
{
    public class ProductsService
    {
        public List<Product> GetProducts()
        {
            using (var context = new MvcComContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetProduct(int ID)
        {
            using (var context = new MvcComContext())
            {
                return context.Products.Find(ID);
            }
        }

        public void SaveProduct(Product product)
        {
            using(var context = new MvcComContext())
            {
                context.Products.Add(product);

                context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var context = new MvcComContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteProduct(int ID)
        {
            using (var context = new MvcComContext())
            {
                var product = context.Products.Find(ID);
                //context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                //both will work
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
