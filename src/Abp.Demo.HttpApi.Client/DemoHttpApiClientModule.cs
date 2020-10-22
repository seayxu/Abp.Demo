using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Abp.Demo
{
    [DependsOn(
        typeof(DemoApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class DemoHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Demo";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(DemoApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
