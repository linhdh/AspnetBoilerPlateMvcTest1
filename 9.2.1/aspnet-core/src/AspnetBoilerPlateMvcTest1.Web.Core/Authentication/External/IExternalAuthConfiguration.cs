using System.Collections.Generic;

namespace AspnetBoilerPlateMvcTest1.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
