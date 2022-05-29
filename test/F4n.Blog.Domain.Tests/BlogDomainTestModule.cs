using F4n.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace F4n.Blog
{
    [DependsOn(
        typeof(BlogEntityFrameworkCoreTestModule)
        )]
    public class BlogDomainTestModule : AbpModule
    {

    }
}