using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Services.IRepositories;

namespace Services.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private TimeSheetContext context;

        public Repository(TimeSheetContext context)
        {
            this.context = context;
        }

        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<TEntity> GetAllItems()
        {
            return context.Set<TEntity>();
        }

        public TEntity GetItem(int id)
        {
            return context.Find<TEntity>(id);
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.SaveChanges();
        }
    }
}
