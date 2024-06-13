using System.Threading.Tasks;
using Abp.Application.Services;
using AspnetBoilerPlateMvcTest1.Sessions.Dto;

namespace AspnetBoilerPlateMvcTest1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
