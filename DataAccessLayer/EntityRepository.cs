using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccessLayer
{
    public class EntityRepository<T> : IRepository<T>
        where T : class, IDomainObject, new()
    {
        public EntityRepository()
        {

            using var context = new AppDbContext();
            context.Database.EnsureCreated();
        }

        public void Create(T obj)
        {
            using var context = new AppDbContext();
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public IEnumerable<T> ReadAll()
        {
            using var context = new AppDbContext();
            return context.Set<T>().AsNoTracking().ToList();
        }

        public T? ReadById(int id)
        {
            using var context = new AppDbContext();
            return context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Update(T obj)
        {
            using var context = new AppDbContext();
            context.Set<T>().Update(obj);
            context.SaveChanges();
        }

        public void Delete(T obj)
        {
            using var context = new AppDbContext();
            var existing = context.Set<T>().Find(obj.Id);
            if (existing != null)
            {
                context.Set<T>().Remove(existing);
                context.SaveChanges();
            }
        }
    }
}
