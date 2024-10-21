using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming_Week3.Repository.Repository
{
    public class CategoriesRepository : RepositoryBase<Categories>
    {

        public IEnumerable<Categories> GetAllCategories()
        {
            return GetEntities();
        }

        public Categories GetCategoriesByID(int pID)
        {
            return GetByID(pID);
        }

        public Categories GetCategoriesByName(string pName)
        {
            return GetByName(pName);
        }

        public bool CreateCategories(Categories category)
        {
            ProductDBEntities.Categories.Add(category);
            return ProductDBEntities.SaveChanges() > 0;
        }

        public bool UpdateCategories(Categories category)
        {
            return Update(category);
        }

        public bool DeleteCategories(Categories category)
        {
            ProductDBEntities.Categories.Remove(category);
            return ProductDBEntities.SaveChanges() > 0;
        }               
    }
}
