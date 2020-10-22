using Abp.Demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Demo
{
    public abstract class DemoController : AbpController
    {
        protected DemoController()
        {
            LocalizationResource = typeof(DemoResource);
        }
    }
}
