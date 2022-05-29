using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace F4n.Blog.Domain.Blog.Repositories
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
    }
}
