using Microsoft.AspNetCore.Mvc;
using SocialMedia.InfraStructure.Repositories;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPosts()
        {
            var Posts = new PostRepository().GetPosts();

            return Ok(Posts);
        }
    }
}