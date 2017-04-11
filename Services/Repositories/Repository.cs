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
        private DbSet<TEntity> entities;

        public Repository(TimeSheetContext context)
        {
            this.context = context;
            entities = this.context.Set<TEntity>();
        }

        public List<TEntity> GetAllItems()
        {
            return entities.ToList();
        }
    }
}
