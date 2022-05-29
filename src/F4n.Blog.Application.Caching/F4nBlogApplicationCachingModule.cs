using F4n.Blog.Domain;
using System;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using F4n.Blog.Domain.Configurations;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;

namespace F4n.Blog.Application.Caching
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(F4nBlogDomainModule)
    )]
    public class F4nBlogApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = AppSettings.Caching.RedisConnectionString;
                //options.InstanceName
                //options.ConfigurationOptions
            });

            var csredis = new CSRedis.CSRedisClient(AppSettings.Caching.RedisConnectionString);
            RedisHelper.Initialization(csredis);

            context.Services.AddSingleton<IDistributedCache>(new CSRedisCache(RedisHelper.Instance));
        }
    }
}
