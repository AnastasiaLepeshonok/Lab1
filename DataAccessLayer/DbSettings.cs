using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DbSettings
    {
        public const string ConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;Database=DecanatDb;Trusted_Connection=True;TrustServerCertificate=True";
    }
}

