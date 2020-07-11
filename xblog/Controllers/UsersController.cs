using System.Linq;
using Microsoft.AspNetCore.Mvc;
using xblog.Repositories;
using xblog.Controllers.Models;
using xblog.Repositories.Models;
using xblog.Services;

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
    [Route("GetUserInfo")]
    public IActionResult GetUserById(int id)
    {
      var user = _usersService.GetUser(id);
      if (user == null)
      {
        return NotFound();
      }
      return Ok(user);
    }

  //  [HttpPost]
  //  [Route("AddUser")]
  //  public IActionResult AddUser(CreateUserRequest model)
  //  {
  //    var newId = UsersRepository.UserList.Max(s => s.Id) + 1;
  //    UsersRepository.UserList.Add(new DbUser { Id = newId, Login = model.Login, Pass = model.Pass, IsEdit = model.IsEdit, FIO = model.FIO });
  //    return Ok(UsersRepository.UserList);
  //  }

  //  [HttpGet]
  //  [Route("GetTempUserInfo")]
  //  public IActionResult GetTempUserInfo()
  //  {
  //    return Ok(UsersRepository.UserList);
  //  }
  }
}
