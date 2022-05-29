using F4n.Blog.Application.Contracts.Blog;
using F4n.Blog.ToolKits.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F4n.Blog.Application.Caching.Blog
{
    public partial interface IBlogCacheService : ICacheRemoveService
    {
        /// <summary>
        /// 根据URL获取文章详情
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        Task<ServiceResult<PostDetailDto>> GetPostDetailAsync(string url, Func<Task<ServiceResult<PostDetailDto>>> factory);
    }
}
