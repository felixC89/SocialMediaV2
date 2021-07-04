using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.InfraStructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.InfraStructure.Repositories
{
   public class PostMongoRepository : IPostRepository
    {
        #region ########## Iyeccion de dependencias de la base de datos ##########
        private readonly SocialMediadbContext _contexto;

        public PostMongoRepository(SocialMediadbContext contexto)
        {
            _contexto = contexto;
        }
        #endregion

        public async Task<IEnumerable<Post>> GetPosts()
        {
            //var Posts = Enumerable.Range(0, 10).Select(x => new Posts
            //{
            //    PostId = x,
            //    Description = $"Description{x}",
            //    Date = DateTime.Now,
            //    Image = $"https://misapis.com/{x}",
            //    UserId = x * 2

            //});

            var Post = await _contexto.Posts.ToListAsync();

            //await Task.Delay(10);
            return Post;
        }
    }
}
