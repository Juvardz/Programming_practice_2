using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming_Week3.Repository
{
    public class RepositoryBase<T> where T : class, IEntity
    {
        protected readonly ProductDBEntities ProductDBEntities;

        public RepositoryBase()
        {
            ProductDBEntities = new ProductDBEntities();
        }

        public IEnumerable<T> GetEntities()
        {
            return ProductDBEntities.Set<T>().ToList();
        }

        public T GetByID(int pID)
        {
            return ProductDBEntities.Set<T>().SingleOrDefault(x => x.ID == pID);
        }

        public T GetByName(string pName)
        {
            return ProductDBEntities.Set<T>().SingleOrDefault(x => x.Name == pName);
        }

        //public bool Create(T entity) 
        //{
        //    ProductDBEntities.Set<T>.Add(entity);
        //    return ProductDBEntities.SaveChanges() > 0;
        //}

        public bool Update(T entity)
        {
            ProductDBEntities.Set<T>().Attach(entity);
            ProductDBEntities.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
            return ProductDBEntities.SaveChanges() > 0;
        }

        //public bool Delete(T entity)
        //{
        //    ProductDBEntities.Set<T>.Remove(entity);
        //    return ProductDBEntities.SaveChanges() > 0;
        //}
    }
}

