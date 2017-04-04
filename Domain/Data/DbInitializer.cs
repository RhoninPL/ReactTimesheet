using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Data
{
    public class DbInitializer
    {
        public static void Initialize(TimeSheetContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
