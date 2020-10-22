using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Demo.EntityFrameworkCore
{
    [ConnectionStringName(DemoDbProperties.ConnectionStringName)]
    public class DemoDbContext : AbpDbContext<DemoDbContext>, IDemoDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DemoDbContext(DbContextOptions<DemoDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureDemo();
        }
    }
}