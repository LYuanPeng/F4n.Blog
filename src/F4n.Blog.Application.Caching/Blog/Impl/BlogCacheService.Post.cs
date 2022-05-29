using F4n.Blog.Application.Contracts.Blog;
using F4n.Blog.ToolKits.Base;
using F4n.Blog.ToolKits.Base.Paged;
using F4n.Blog.ToolKits.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static F4n.Blog.Domain.Shared.F4nBlogConsts;

namespace F4n.Blog.Application.Caching.Blog.Impl
{
    public partial class BlogCacheService
    {
        private const string KEY_QueryPosts = "Blog:Post:QueryPosts-{0}-{1}";
        private const string KEY_QueryPostsByCategory = "Blog:Post:QueryPostsByCategory-{0}";
        private const string KEY_QueryPostsByTag = "Blog:Post:QueryPostsByTag-{0}";

        /// <summary>
        /// 分页查询文章列表
        /// </summary>
        /// <param name="input"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public async Task<ServiceResult<PagedList<QueryPostDto>>> QueryPostsAsync(PagingInput input, Func<Task<ServiceResult<PagedList<QueryPostDto>>>> factory)
        {
            return await Cache.GetOrAddAsync(KEY_QueryPosts.FormatWith(input.Page, input.Limit), factory, CacheStrategy.ONE_DAY);
        }

        /// <summary>
        /// 通过分类名称查询文章列表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public async Task<ServiceResult<IEnumerable<QueryPostDto>>> QueryPostsByCategoryAsync(string name, Func<Task<ServiceResult<IEnumerable<QueryPostDto>>>> factory)
        {
            return await Cache.GetOrAddAsync(KEY_QueryPostsByCategory.FormatWith(name), factory, CacheStrategy.ONE_DAY);
        }

        /// <summary>
        /// 通过标签名称查询文章列表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public async Task<ServiceResult<IEnumerable<QueryPostDto>>> QueryPostsByTagAsync(string name, Func<Task<ServiceResult<IEnumerable<QueryPostDto>>>> factory)
        {
            return await Cache.GetOrAddAsync(KEY_QueryPostsByTag.FormatWith(name), factory, CacheStrategy.ONE_DAY);
        }
    }
}
