using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AspnetBoilerPlateMvcTest1.EntityFrameworkCore
{
    public static class AspnetBoilerPlateMvcTest1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AspnetBoilerPlateMvcTest1DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AspnetBoilerPlateMvcTest1DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
