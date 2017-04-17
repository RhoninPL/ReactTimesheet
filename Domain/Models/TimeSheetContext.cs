using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public class TimeSheetContext : DbContext
    {
        public TimeSheetContext(DbContextOptions<TimeSheetContext> options) : base(options)
        { }

        //public TimeSheetContext() { }

        public DbSet<TimeSheetEntry> Entries { get; set; }
        public DbSet<Company> Companies { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Domain;Trusted_Connection=True;");
        //    base.OnConfiguring(builder);
        //}
    }
}
