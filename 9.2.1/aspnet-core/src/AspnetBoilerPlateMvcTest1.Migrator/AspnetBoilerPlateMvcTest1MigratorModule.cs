using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspnetBoilerPlateMvcTest1.Configuration;
using AspnetBoilerPlateMvcTest1.EntityFrameworkCore;
using AspnetBoilerPlateMvcTest1.Migrator.DependencyInjection;

namespace AspnetBoilerPlateMvcTest1.Migrator
{
    [DependsOn(typeof(AspnetBoilerPlateMvcTest1EntityFrameworkModule))]
    public class AspnetBoilerPlateMvcTest1MigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AspnetBoilerPlateMvcTest1MigratorModule(AspnetBoilerPlateMvcTest1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AspnetBoilerPlateMvcTest1MigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AspnetBoilerPlateMvcTest1Consts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspnetBoilerPlateMvcTest1MigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
