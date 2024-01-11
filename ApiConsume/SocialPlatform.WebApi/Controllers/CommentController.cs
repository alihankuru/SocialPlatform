using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialPlatform.BusinessLayer.Abstract;
using SocialPlatform.EntityLayer.Concrete;

namespace SocialPlatform.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        // Constructor to initialize the controller with an instance of ICommentService
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        // GET: api/comment
        // Retrieves a list of comments
        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentService.TGetList();
            return Ok(values);
        }

        // POST: api/comment
        // Adds a new comment

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            _commentService.TInsert(comment);
            return Ok();
        }


        // DELETE: api/comment/{id}
        // Deletes a comment by ID
        [HttpDelete]
        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.TGetByID(id);
            _commentService.TDelete(values);
            return Ok();
        }


        // PUT: api/comment
        // Updates an existing comment
        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentService.TUpdate(comment);
            return Ok();
        }

        // GET: api/comment/{id}
        // Retrieves a specific comment by ID
        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var values = _commentService.TGetByID(id);
            return Ok(values);
        }
    }
}
