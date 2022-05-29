using F4n.Blog.Domain.Blog;
using F4n.Blog.Domain.Blog.Repositories;
using F4n.Blog.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace F4n.Blog.Pepositories.Blog
{
    public class FriendLinkRepository : EfCoreRepository<F4nBlogDbContext, FriendLink, int>, IFriendLinkRepository
    {
        public FriendLinkRepository(IDbContextProvider<F4nBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
