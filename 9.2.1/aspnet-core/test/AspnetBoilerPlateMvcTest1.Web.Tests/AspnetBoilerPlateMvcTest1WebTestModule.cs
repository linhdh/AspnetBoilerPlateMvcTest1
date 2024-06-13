using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspnetBoilerPlateMvcTest1.EntityFrameworkCore;
using AspnetBoilerPlateMvcTest1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AspnetBoilerPlateMvcTest1.Web.Tests
{
    [DependsOn(
        typeof(AspnetBoilerPlateMvcTest1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AspnetBoilerPlateMvcTest1WebTestModule : AbpModule
    {
        public AspnetBoilerPlateMvcTest1WebTestModule(AspnetBoilerPlateMvcTest1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspnetBoilerPlateMvcTest1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AspnetBoilerPlateMvcTest1WebMvcModule).Assembly);
        }
    }
}