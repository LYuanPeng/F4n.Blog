using F4n.Blog.Domain.Blog;
using F4n.Blog.Domain.Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace F4n.Blog.EntityFrameworkCore.Pepositories.Blog
{
    public class PostRepository : EfCoreRepository<F4nBlogDbContext, Post, int>, IPostRepository
    {
        public PostRepository(IDbContextProvider<F4nBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
