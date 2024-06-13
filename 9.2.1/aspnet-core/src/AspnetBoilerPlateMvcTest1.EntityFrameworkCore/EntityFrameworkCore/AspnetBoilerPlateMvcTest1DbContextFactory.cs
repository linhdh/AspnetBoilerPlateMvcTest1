using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AspnetBoilerPlateMvcTest1.Configuration;
using AspnetBoilerPlateMvcTest1.Web;

namespace AspnetBoilerPlateMvcTest1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AspnetBoilerPlateMvcTest1DbContextFactory : IDesignTimeDbContextFactory<AspnetBoilerPlateMvcTest1DbContext>
    {
        public AspnetBoilerPlateMvcTest1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AspnetBoilerPlateMvcTest1DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AspnetBoilerPlateMvcTest1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(AspnetBoilerPlateMvcTest1Consts.ConnectionStringName));

            return new AspnetBoilerPlateMvcTest1DbContext(builder.Options);
        }
    }
}
