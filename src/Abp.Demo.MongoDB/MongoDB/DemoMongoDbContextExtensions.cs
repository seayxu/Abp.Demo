using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Abp.Demo.MongoDB
{
    public static class DemoMongoDbContextExtensions
    {
        public static void ConfigureDemo(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DemoMongoModelBuilderConfigurationOptions(
                DemoDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}