using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspnetBoilerPlateMvcTest1.Authorization;

namespace AspnetBoilerPlateMvcTest1
{
    [DependsOn(
        typeof(AspnetBoilerPlateMvcTest1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AspnetBoilerPlateMvcTest1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AspnetBoilerPlateMvcTest1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AspnetBoilerPlateMvcTest1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
