using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using SocialMedia.Core.Interfaces;
using System.Threading.Tasks;
using SocialMedia.InfraStructure.Data;
using Microsoft.EntityFrameworkCore;

namespace SocialMedia.InfraStructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        #region ########## Iyeccion de dependencias de la base de datos ##########
        private readonly SocialMediadbContext _contexto;

        public PostRepository(SocialMediadbContext contexto)
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

        public async Task<Post> GetPost(int id)
        {
            var Post = await _contexto.Posts.FirstOrDefaultAsync(x=>x.PostId==id);

            return Post;
        }
    }
}
