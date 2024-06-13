using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AspnetBoilerPlateMvcTest1.Configuration.Dto;

namespace AspnetBoilerPlateMvcTest1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AspnetBoilerPlateMvcTest1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
