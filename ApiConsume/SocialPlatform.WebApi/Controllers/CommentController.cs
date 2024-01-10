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
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            _commentService.TInsert(comment);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.TGetByID(id);
            _commentService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentService.TUpdate(comment);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var values = _commentService.TGetByID(id);
            return Ok(values);
        }
    }
}
