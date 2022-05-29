using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;

namespace F4n.Blog.EntityFrameworkCore.DbMigrations
{
    public class F4nBlogMigrationsDbContext :  AbpDbContext<F4nBlogMigrationsDbContext>
    {
        public F4nBlogMigrationsDbContext(DbContextOptions<F4nBlogMigrationsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure();
        }
    }
}
