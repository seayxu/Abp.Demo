using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Abp.Demo
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(DemoDomainSharedModule)
    )]
    public class DemoDomainModule : AbpModule
    {

    }
}
