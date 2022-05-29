using F4n.Blog.EntityFrameworkCore;
using F4n.Blog.EntityFrameworkCore.DbMigrations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace F4n.Blog
{
    [DependsOn(typeof(F4nBlogFrameworkCoreModule))]
    public class F4nBlogEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<F4nBlogMigrationsDbContext>();
        }
    }
}
