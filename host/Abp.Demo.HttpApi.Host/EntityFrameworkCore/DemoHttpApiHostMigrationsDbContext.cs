﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Demo.EntityFrameworkCore
{
    public class DemoHttpApiHostMigrationsDbContext : AbpDbContext<DemoHttpApiHostMigrationsDbContext>
    {
        public DemoHttpApiHostMigrationsDbContext(DbContextOptions<DemoHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureDemo();
        }
    }
}
