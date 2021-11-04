using CustomerConnectionsApp.Domain.Models;
using CustomerConnectionsApp.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerConnectionsApp.EntityFramework.ViewModelServices
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObjectId
    {
        private readonly DataContext dataContext;

        public GenericDataService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<T> Create(T entity)
        {
            using (var context = new DataContext())
            {
                var createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (var context = new DataContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (var context = new DataContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                await context.SaveChangesAsync();

                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (var context = new DataContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                await context.SaveChangesAsync();

                return entities;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (var context = new DataContext())
            {
                entity.Id = id;

                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
