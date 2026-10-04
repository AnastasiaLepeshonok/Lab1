using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DbSettings
    {
        private const string DefaultConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;Database=DecanatDb;Trusted_Connection=True;TrustServerCertificate=True";

        public static string ConnectionString =>
            Environment.GetEnvironmentVariable("DECANAT_DATABASE_CONNECTION")
            ?? DefaultConnectionString;
    }
}

