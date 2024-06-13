using Abp.Application.Services;
using AspnetBoilerPlateMvcTest1.MultiTenancy.Dto;

namespace AspnetBoilerPlateMvcTest1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

