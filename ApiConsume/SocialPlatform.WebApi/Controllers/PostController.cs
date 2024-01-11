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
        // Constructor to initialize the controller with an instance of IPostService
        public PostController(IPostService postService)
        {
            _postService = postService;

        }

        // GET: api/post
        // Retrieves a list of posts
        [HttpGet]
        public IActionResult PostList()
        {
            var values = _postService.TGetList();
            return Ok(values);
        }

        // POST: api/post
        // Adds a new post
        [HttpPost]
        public IActionResult AddPost(Post post)
        {
            _postService.TInsert(post);
            return Ok();
        }


        // DELETE: api/post/{id}
        // Deletes a post by ID
        [HttpDelete]
        public IActionResult DeletePost(int id)
        {
            var values = _postService.TGetByID(id);
            _postService.TDelete(values);
            return Ok();
        }

        // PUT: api/post
        // Updates an existing post
        [HttpPut]
        public IActionResult UpdatePost(Post post)
        {
            _postService.TUpdate(post);
            return Ok();
        }

        // GET: api/post/{id}
        // Retrieves a specific post by ID
        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var values = _postService.TGetByID(id);
            return Ok(values);
        }
    }
}
