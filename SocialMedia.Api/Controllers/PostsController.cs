using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Interfaces;
using SocialMedia.InfraStructure.Repositories;
using System.Threading.Tasks;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        #region ############## Inversion de dependecias ##############
        private readonly IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var Posts = await _postRepository.GetPosts();

            return Ok(Posts);
        }
    }
}