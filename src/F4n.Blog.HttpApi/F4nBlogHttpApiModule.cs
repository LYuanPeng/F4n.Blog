
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using F4n.Blog.Application;

namespace F4n.Blog
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(F4nBlogApplicationModule)
        )]
    public class F4nBlogHttpApiModule : AbpModule
    {
        
    }
}
