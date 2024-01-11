using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialPlatform.EntityLayer.Concrete;
using SocialPlatform.EntityLayer.Services;

namespace SocialPlatform.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(IAuthService authService, ILogger<AuthenticationController> logger)
        {
            _authService = authService;
            _logger = logger;
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid payload");
                var (status, message) = await _authService.Login(model);
                if (status == 0)
                    return BadRequest(message);
                // Return an OK response with the authentication message
                return Ok(message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                // Return a 500 Internal Server Error response with the exception message
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //Example Register
//          {
//              "username":"akk",
//              "email":"ak@gmail.com",
//              "password":"Ak@123",
//              "name":"Al Kuru"
//          }


        [HttpPost]
        [Route("registeration")]
        public async Task<IActionResult> Register(RegistrationModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid payload");
                var (status, message) = await _authService.Registeration(model, UserRoles.User);
                // Check the authentication status
                if (status == 0)
                {
                    return BadRequest(message);
                }
                return CreatedAtAction(nameof(Register), model);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                // Return a 500 Internal Server Error response with the exception message
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }

}
