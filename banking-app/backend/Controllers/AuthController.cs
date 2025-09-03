using Microsoft.AspNetCore.Mvc;
using BankingApp.DTOs;
using BankingApp.Services;

namespace BankingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly UserManager<IdentityUser> userManager;
        public AuthController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }




        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerRequestDto.Username,
                Email = registerRequestDto.Username
            };
            var identityResult = await _userManager.CreateAsync(identityUser, registerRequestDto.Password);

            if (identityResult.Succeeded)
            {
                // add roles to this user

                if (registerRequestDto.Roles != null && registerRequestDto.Roles.any())
                {
                    // add default role

                    identityResult = await _userManager.AddToRoleAsync(identityUser, "User");
                    if (identityResult.Succeeded)
                    {
                        return Ok("User registered successfully , please login. ");
                    }
                }
            }
            return BadRequest("Something went wrong");



        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var result = await _authService.LoginAsync(loginDto);
            if (!result.Success)
            {
                return Unauthorized(result.Message);
            }
            return Ok(new { Token = result.Token });
        }
    }
}
