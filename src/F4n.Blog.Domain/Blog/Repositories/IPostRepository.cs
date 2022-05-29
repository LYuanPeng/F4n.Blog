using F4n.Blog.Domain.Blog;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace F4n.Blog.Domain.Blog.Repositories
{
    public interface IPostRepository : IRepository<Post, int>
    {

    }
}
