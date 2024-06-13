using Abp.MultiTenancy;
using AspnetBoilerPlateMvcTest1.Authorization.Users;

namespace AspnetBoilerPlateMvcTest1.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
