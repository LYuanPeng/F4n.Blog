using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace F4n.Blog.Domain
{
    [DependsOn(typeof(AbpIdentityDomainModule))]
    public class F4nBlogDomainModule : AbpModule
    {
    }
}
