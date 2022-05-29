using F4n.Blog.Application.Caching;
using F4n.Blog.Domain.Configurations;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Caching;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;


namespace F4n.Blog.Application
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(F4nBlogApplicationCachingModule)
        )]
    public class F4nBlogApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = AppSettings.Caching.RedisConnectionString;
            });

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<F4nBlogApplicationModule>(validate: true);
                options.AddProfile<F4nBlogAutoMapperProfile>(validate: true);
            });
        }
    }
}
