using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Identity;

namespace Abp.Demo.Controllers
{
    [Route("/api/dynamic")]
    public class DynamicController : AbpController
    {
        IIdentityUserAppService IdentityUserAppService;

        public DynamicController(IIdentityUserAppService identityUserAppService)
        {
            IdentityUserAppService = identityUserAppService;
        }

        [HttpGet]
        public async Task<IdentityUserDto> GetAsync(string name)
        {
            return await IdentityUserAppService.FindByUsernameAsync(username: name);
        }
    }
}
