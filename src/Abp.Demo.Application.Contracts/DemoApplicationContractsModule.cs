using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Abp.Demo
{
    [DependsOn(
        typeof(DemoDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class DemoApplicationContractsModule : AbpModule
    {

    }
}
