using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parking_Intelligence_Api.Schemas;
using Parking_Intelligence_Api.Services.User;

namespace Parking_Intelligence_Api.Controllers.User;

[ApiController]
[Route("v1")]
public class UserController : ControllerBase
{
    [HttpPost]
    [Route("user/create")]
    [AllowAnonymous]
    public async Task<IActionResult> CreateUser([FromBody] UserSchema user)
    {
        var service = new CreateUserServices();

        if (service.SearchingforUser(user.Email, user.Cpf, user.Phone))
            return BadRequest("user already exists");

        if (
            !service.ValidateCredentials(
                user.Email,
                user.Nickname,
                user.Fullname,
                user.Cpf,
                user.Phone,
                user.Password
            )
        )
            return BadRequest("to something wrong in one of the fields");

        return Ok(await service.CreateNewUser(user));
    }

    [HttpPost]
    [Route("login")]
    [AllowAnonymous]
    public IActionResult LoginUser([FromBody] LoginSchema user)
    {
        var validations = new LoginServices();
        if (!validations.ValidateCredentials(user))
            return BadRequest("invalid credentials");
        var userValidation = validations.ReturnUser(user);
        if (userValidation is null)
            return BadRequest("null user or invalid credentials");
        return Ok(userValidation);
    }
}