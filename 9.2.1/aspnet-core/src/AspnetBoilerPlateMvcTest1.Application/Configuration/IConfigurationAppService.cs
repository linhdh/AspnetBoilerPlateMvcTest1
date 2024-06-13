using System.Threading.Tasks;
using AspnetBoilerPlateMvcTest1.Configuration.Dto;

namespace AspnetBoilerPlateMvcTest1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
