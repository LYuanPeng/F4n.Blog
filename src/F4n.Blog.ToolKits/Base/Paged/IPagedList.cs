using System;
using System.Collections.Generic;
using System.Text;

namespace F4n.Blog.ToolKits.Base.Paged
{
    public interface IPagedList<T> : IListResult<T>, IHasTotalCount
    {
    }
}
