using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.InfraStructure.Repositories
{
   public class PostMongoRepository : IPostRepository
    {
        public async Task<IEnumerable<Post>> GetPosts()
        {
            var Post = Enumerable.Range(0, 10).Select(x => new Post
            {
                PostId = x,
                Description = $"Descripcion Mongo {x}",
                Date = DateTime.Now,
                Image = $"https://misapis.com/{x}",
                UserId = x * 2

            });

            await Task.Delay(10);
            return Post;
        }
    }
}
