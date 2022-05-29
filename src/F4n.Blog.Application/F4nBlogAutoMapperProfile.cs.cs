using AutoMapper;
using F4n.Blog.Application.Contracts.Blog;
using F4n.Blog.Domain.Blog;
using System;
using System.Collections.Generic;
using System.Text;

namespace F4n.Blog.Application
{
    public class F4nBlogAutoMapperProfile : Profile
    {
        public F4nBlogAutoMapperProfile()
        {
            CreateMap<Post, PostDto>();

            CreateMap<PostDto, Post>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<FriendLink, FriendLinkDto>();

            CreateMap<EditPostInput, Post>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<Post, PostForAdminDto>().ForMember(x => x.Tags, opt => opt.Ignore());

            CreateMap<EditCategoryInput, Category>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<EditTagInput, Tag>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<FriendLink, QueryFriendLinkForAdminDto>();

            CreateMap<EditFriendLinkInput, FriendLink>().ForMember(x => x.Id, opt => opt.Ignore());

        }
    }
}
