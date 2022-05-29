using F4n.Blog.Domain.Blog;
using F4n.Blog.Domain.Blog.Repositories;
using F4n.Blog.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace F4n.Blog.Pepositories.Blog
{
    public class TagRepository : EfCoreRepository<F4nBlogDbContext, Tag, int>, ITagRepository
    {
        public TagRepository(IDbContextProvider<F4nBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task BulkInsertAsync(IEnumerable<Tag> tags)
        {
            await DbContext.Set<Tag>().AddRangeAsync(tags);
            await DbContext.SaveChangesAsync();
        }
    }
}
