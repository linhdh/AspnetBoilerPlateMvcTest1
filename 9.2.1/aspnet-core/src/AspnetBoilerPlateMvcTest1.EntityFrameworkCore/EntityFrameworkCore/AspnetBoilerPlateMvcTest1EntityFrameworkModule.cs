using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using AspnetBoilerPlateMvcTest1.EntityFrameworkCore.Seed;

namespace AspnetBoilerPlateMvcTest1.EntityFrameworkCore
{
    [DependsOn(
        typeof(AspnetBoilerPlateMvcTest1CoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AspnetBoilerPlateMvcTest1EntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AspnetBoilerPlateMvcTest1DbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AspnetBoilerPlateMvcTest1DbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AspnetBoilerPlateMvcTest1DbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspnetBoilerPlateMvcTest1EntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
