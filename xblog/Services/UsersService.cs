using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xblog.Repositories;
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
  }
}
