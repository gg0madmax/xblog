using System.Linq;
using Microsoft.AspNetCore.Mvc;
using xblog.Repositories;
using xblog.Controllers.Models;
using xblog.Repositories.Models;
using xblog.Services;
using xblog.Services.Models;

namespace xblog.Controllers
{
  [Route("api/Users")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly UsersService _usersService;
    public UsersController()
    {
      _usersService = new UsersService();
    }

    [HttpGet]
    [Route("GetUserById")]
    public IActionResult GetUserById(int id)
    {
      var user = _usersService.GetUser(id);
      if (user == null)
      {
        return NotFound();
      }
      return Ok(user);
    }

    [HttpPost]
    [Route("AddUser")]
    public IActionResult AddUser(CreateUserRequest user)
    {
      var fillUser = new User { Id = 0, FIO = user.FIO, Login = user.Login, Pass = user.Pass, IsEdit = user.IsEdit };
      var addUser = _usersService.AddUser(fillUser);
      return Ok(addUser);
    }

    [HttpGet]
    [Route("GetUsersInfo")]
    public IActionResult GetUsersInfo()
    {
      return Ok(_usersService.GetUsersList());
    }
  }
}
