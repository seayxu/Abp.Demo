using Volo.Abp.Modularity;

namespace Abp.Demo
{
    [DependsOn(
        typeof(DemoApplicationModule),
        typeof(DemoDomainTestModule)
        )]
    public class DemoApplicationTestModule : AbpModule
    {

    }
}
