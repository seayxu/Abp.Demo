using Abp.Demo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Demo
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(DemoEntityFrameworkCoreTestModule)
        )]
    public class DemoDomainTestModule : AbpModule
    {
        
    }
}
