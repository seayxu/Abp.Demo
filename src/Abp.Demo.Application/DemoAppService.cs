using Abp.Demo.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Demo
{
    public abstract class DemoAppService : ApplicationService
    {
        protected DemoAppService()
        {
            LocalizationResource = typeof(DemoResource);
            ObjectMapperContext = typeof(DemoApplicationModule);
        }
    }
}
