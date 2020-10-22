using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Abp.Demo
{
    [DependsOn(
        typeof(DemoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DemoConsoleApiClientModule : AbpModule
    {
        
    }
}
