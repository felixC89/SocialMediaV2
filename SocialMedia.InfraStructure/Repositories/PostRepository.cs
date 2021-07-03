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

        public async Task<IEnumerable<Publicacion>> GetPosts()
        {
            //var Post = Enumerable.Range(0, 10).Select(x => new Post
            //{
            //    PostId = x,
            //    Description = $"Descripcion{x}",
            //    Date = DateTime.Now,
            //    Image = $"https://misapis.com/{x}",
            //    UserId = x * 2

            //});

            var Post = await _contexto.Publicacion.ToListAsync();

            //await Task.Delay(10);
            return Post;
        }
    }
}
