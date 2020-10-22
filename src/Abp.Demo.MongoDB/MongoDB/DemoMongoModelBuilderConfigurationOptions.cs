using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Abp.Demo.MongoDB
{
    public class DemoMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public DemoMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}