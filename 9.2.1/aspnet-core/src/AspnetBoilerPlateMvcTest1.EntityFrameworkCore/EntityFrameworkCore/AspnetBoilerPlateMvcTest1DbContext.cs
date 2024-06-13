using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AspnetBoilerPlateMvcTest1.Authorization.Roles;
using AspnetBoilerPlateMvcTest1.Authorization.Users;
using AspnetBoilerPlateMvcTest1.MultiTenancy;

namespace AspnetBoilerPlateMvcTest1.EntityFrameworkCore
{
    public class AspnetBoilerPlateMvcTest1DbContext : AbpZeroDbContext<Tenant, Role, User, AspnetBoilerPlateMvcTest1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AspnetBoilerPlateMvcTest1DbContext(DbContextOptions<AspnetBoilerPlateMvcTest1DbContext> options)
            : base(options)
        {
        }
    }
}
