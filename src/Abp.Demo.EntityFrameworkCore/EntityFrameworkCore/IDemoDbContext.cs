using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Demo.EntityFrameworkCore
{
    [ConnectionStringName(DemoDbProperties.ConnectionStringName)]
    public interface IDemoDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}