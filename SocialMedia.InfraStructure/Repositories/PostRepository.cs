using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.InfraStructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
            {

                var Post = Enumerable.Range(0, 10).Select(x=> new Post {
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
