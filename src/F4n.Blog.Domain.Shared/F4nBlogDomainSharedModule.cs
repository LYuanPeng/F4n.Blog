using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace F4n.Blog.Domain.Shared
{
    [DependsOn(typeof(AbpIdentityDomainSharedModule))]
    public class F4nBlogDomainSharedModule : AbpModule
    {
    }
}
