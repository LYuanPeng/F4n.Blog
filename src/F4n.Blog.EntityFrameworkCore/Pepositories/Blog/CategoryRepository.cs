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
    public class CategoryRepository : EfCoreRepository<F4nBlogDbContext, Category, int>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<F4nBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
