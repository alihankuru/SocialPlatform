using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialPlatform.BusinessLayer.Abstract;
using SocialPlatform.EntityLayer.Concrete;

namespace SocialPlatform.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;

        }

        [HttpGet]
        public IActionResult PostList()
        {
            var values = _postService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddPost(Post post)
        {
            _postService.TInsert(post);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletePost(int id)
        {
            var values = _postService.TGetByID(id);
            _postService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePost(Post post)
        {
            _postService.TUpdate(post);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var values = _postService.TGetByID(id);
            return Ok(values);
        }
    }
}
