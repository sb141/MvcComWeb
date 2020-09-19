using MvcComDatabase;
using MvcComEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcComServices
{
    public class CategoriesServices
    {
        public List<Category> GetCategory()
        {
            using (var context = new MvcComContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetCategory(int ID)
        {
            using (var context = new MvcComContext())
            {
                return context.Categories.Find(ID);
            }
        }

        public void SaveCategory(Category category)
        {
            using(var context = new MvcComContext())
            {
                context.Categories.Add(category);

                context.SaveChanges();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new MvcComContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int ID)
        {
            using (var context = new MvcComContext())
            {
                var category = context.Categories.Find(ID);
                //context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                //both will work
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
