using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Services.IRepositories
{
    public interface IRepository<TEntity> : IDisposable
    {
        IQueryable<TEntity> GetAllItems();
    }
}