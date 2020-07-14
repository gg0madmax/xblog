using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xblog.Repositories;
using xblog.Repositories.Models;
using xblog.Services.Models;

namespace xblog.Services
{
  public class UsersService
  {
    private readonly ArticlesRepository _articlesRepository;
    private readonly CommentsRepository _commentsRepository;
    private readonly UsersRepository _usersRepository;

    public UsersService()
    {
      _articlesRepository = new ArticlesRepository();
      _commentsRepository = new CommentsRepository();
      _usersRepository = new UsersRepository();
    }

    public IEnumerable<User> GetUsersList()
    {
      var usersList = _usersRepository.GetAllUsers().Select(s => new User() { Id = s.Id, FIO = s.FIO, Login = s.Login, Pass = s.Pass, IsEdit = s.IsEdit });
      return usersList;
    }

    public User GetUser(int id)
    {
      var dbUser = _usersRepository.GetUser(id);
      var user = new User()
      {
        Id = dbUser.Id,
        FIO = dbUser.FIO,
        Login = dbUser.Login
      };
      return user;
    }
    public bool AddUser(User user)
    {
      var dbNewId = _usersRepository.GetAllUsers().Max(s => s.Id) + 1;
      var fillUser = new DbUser { Id = dbNewId, FIO = user.FIO, Login = user.Login, Pass = user.Pass, IsEdit = user.IsEdit };
      var dbUserAdd = _usersRepository.InsertUser(fillUser);
      return dbUserAdd;
    }
  }
}
