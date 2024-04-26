using CareTrackPlus.Api.Models.Admin;
using CareTrackPlus.Api.Models.Authentication.SignUp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CareTrackPlus.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        //admin method to create a default username and password for a specific role
      
        [HttpPost("Register employee's")]
        public async Task<IActionResult> CreateDefaultUser([FromBody] RegisterEmployee registerEmployee, string role)
        {
            //check if the role exist, if not create
            if (!await _roleManager.RoleExistsAsync(role))
            {
                await _roleManager.CreateAsync(new IdentityRole(role));
            }
            var user = new IdentityUser { UserName = registerEmployee.DefaultUserName};
            var result = await _userManager.CreateAsync(user, registerEmployee.DefaultPassword);

      
            if (result.Succeeded)
            {
                //assign user to a specific role
                await _userManager.AddToRoleAsync(user, role);
                return Ok("User created successfully");
            }
            else
            {
                //failed to create user, return error message
                return BadRequest(result.Errors);
            }
        }
    }
}
