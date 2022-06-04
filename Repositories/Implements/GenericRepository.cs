
using logica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace logica.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        //private readonly LogicaContext logicaContext;
        private readonly PruebasSatelitesContext pruebasSatelitesContext;
    


        public GenericRepository(PruebasSatelitesContext pruebasSatelitesContext)
        {
            this.pruebasSatelitesContext = pruebasSatelitesContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            pruebasSatelitesContext.Set<TEntity>().Remove(entity);
            await pruebasSatelitesContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await pruebasSatelitesContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await pruebasSatelitesContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            pruebasSatelitesContext.Set<TEntity>().Add(entity);
            await pruebasSatelitesContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            pruebasSatelitesContext.Entry(entity).State = EntityState.Added;
            // pruebasSatelitesContext.Set<TEntity>().AddOrUpdate(entity);

            await pruebasSatelitesContext.SaveChangesAsync();
            return entity;
        }
    }
}
