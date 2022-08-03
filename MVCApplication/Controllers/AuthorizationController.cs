
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace MVCApplication.Controllers
{
    public class AuthorizationController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class AuthController : ControllerBase
        {
            private readonly IAuthorizationService _authService;

            public AuthController(IAuthorizationService authService)
            {
                _authService = authService;
            }

            [HttpPost]
            public IActionResult Token(Owner owner)
            {
                return Ok(_authService.Post(owner));

            }
        }
    }
}
