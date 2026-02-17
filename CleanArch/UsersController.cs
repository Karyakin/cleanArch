using CleanArch.Application.Contracts;
using CleanArch.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch;

[ApiController]
[Route("api/users")]
[Produces("application/json")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Получение пользователя по ID
    /// </summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <response code="200">Пользователь найден</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpGet("{id:guid}")]
    [ProducesResponseType<UserDto>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> GetById(Guid id, CancellationToken ct)
    {
        var dto = await _userService.GetUserByIdAsync(id, ct);

        if (dto is null)
        {
            return NotFound();
        }

        return Ok(dto);
    }
}