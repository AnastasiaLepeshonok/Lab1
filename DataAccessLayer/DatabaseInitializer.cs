using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class DatabaseInitializer
    {
        public static void EnsureCreated()
        {
            using var context = new AppDbContext();
            context.Database.EnsureCreated();
        }
    }
}
