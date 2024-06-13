using Abp.Authorization;
using AspnetBoilerPlateMvcTest1.Authorization.Roles;
using AspnetBoilerPlateMvcTest1.Authorization.Users;

namespace AspnetBoilerPlateMvcTest1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
