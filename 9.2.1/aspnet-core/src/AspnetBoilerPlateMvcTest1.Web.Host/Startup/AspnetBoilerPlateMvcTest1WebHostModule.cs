using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspnetBoilerPlateMvcTest1.Configuration;

namespace AspnetBoilerPlateMvcTest1.Web.Host.Startup
{
    [DependsOn(
       typeof(AspnetBoilerPlateMvcTest1WebCoreModule))]
    public class AspnetBoilerPlateMvcTest1WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AspnetBoilerPlateMvcTest1WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspnetBoilerPlateMvcTest1WebHostModule).GetAssembly());
        }
    }
}
