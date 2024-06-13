using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AspnetBoilerPlateMvcTest1.MultiTenancy;

namespace AspnetBoilerPlateMvcTest1.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
