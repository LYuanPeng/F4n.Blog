using F4n.Blog.Application.Contracts.Blog;
using F4n.Blog.ToolKits.Base;
using F4n.Blog.ToolKits.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static F4n.Blog.Domain.Shared.F4nBlogConsts;

namespace F4n.Blog.Application.Caching.Blog.Impl
{
    public partial class BlogCacheService : F4nBlogApplicationCachingServiceBase, IBlogCacheService
    {
        private const string KEY_GetPostDetail = "Blog:Post:GetPostDetail-{0}";

        /// <summary>
        /// 根据URL获取文章详情
        /// </summary>
        /// <param name="url"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public async Task<ServiceResult<PostDetailDto>> GetPostDetailAsync(string url, Func<Task<ServiceResult<PostDetailDto>>> factory)
        {
            return await Cache.GetOrAddAsync(KEY_GetPostDetail.FormatWith(url), factory, CacheStrategy.ONE_DAY);
        }
    }
}
