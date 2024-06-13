using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AspnetBoilerPlateMvcTest1.Controllers
{
    public abstract class AspnetBoilerPlateMvcTest1ControllerBase: AbpController
    {
        protected AspnetBoilerPlateMvcTest1ControllerBase()
        {
            LocalizationSourceName = AspnetBoilerPlateMvcTest1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
