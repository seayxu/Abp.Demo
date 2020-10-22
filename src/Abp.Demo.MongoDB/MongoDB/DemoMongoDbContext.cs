using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Demo.MongoDB
{
    [ConnectionStringName(DemoDbProperties.ConnectionStringName)]
    public class DemoMongoDbContext : AbpMongoDbContext, IDemoMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureDemo();
        }
    }
}