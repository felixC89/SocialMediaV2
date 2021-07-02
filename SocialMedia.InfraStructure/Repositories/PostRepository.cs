using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using SocialMedia.Core.Interfaces;
using System.Threading.Tasks;

namespace SocialMedia.InfraStructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        Task<IEnumerable<Post>> IPostRepository.GetPosts()
        {
            var Post = (Task<IEnumerable<Post>>)Enumerable.Range(0, 10).Select(x => new Post
            {
                PostId = x,
                Description = $"Descripcion{x}",
                Date = DateTime.Now,
                Image = $"https://misapis.com/{x}",
                UserId = x * 2

            });

            return Post;
        }
    }
}
