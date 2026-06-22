using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using InternApiJwtAuthentication.Services;
using InternApiJwtAuthentication.DTOs;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserService _userService;

    public UsersController(UserService userService)
    {
        _userService = userService;
    }

    // 🔑 LOGIN
    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        var token = _userService.Login(dto.Email, dto.Password);
        if (token == null) return Unauthorized("Invalid credentials");
        return Ok(new { message = "Login successful", token });
    }

    // ✏️ UPDATE
    [Authorize]
    [HttpPut("update/{id}")]
    public IActionResult Update(int id, UserUpdateDto dto)
    {
        var user = _userService.UpdateUser(id, dto);
        if (user is null) return NotFound();
        return Ok(new { message = "User updated successfully", user });
    }

    // 🗑️ DELETE
    [Authorize]
    [HttpDelete("delete/{id}")]
    public IActionResult Delete(int id)
    {
        var result = _userService.DeleteUser(id);
        if (!result) return NotFound();
        return Ok(new { message = "User deleted successfully" });
    }

    // 👀 VIEW ALL
    [Authorize]
    [HttpGet("view")]
    public IActionResult View()
    {
        var users = _userService.GetAllUsers();
        return Ok(users);
    }
}
