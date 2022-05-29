using F4n.Blog.Application.HelloWorld;
using System;
using System.Collections.Generic;
using System.Text;

namespace F4n.Blog.Application.HelloWorld.Impl
{
    public class HelloWorldService : F4nBlogApplicationServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello world";
        }
    }
}
