using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Demo.MongoDB
{
    [ConnectionStringName(DemoDbProperties.ConnectionStringName)]
    public interface IDemoMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
