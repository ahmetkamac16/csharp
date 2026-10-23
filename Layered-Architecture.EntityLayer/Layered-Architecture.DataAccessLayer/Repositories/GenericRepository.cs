using Layered_Architecture.DataAccessLayer.Abstract;
using Layered_Architecture.DataAccessLayer.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Layered_Architecture.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        ExampleContext context = new ExampleContext();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>(); 
        }

        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
