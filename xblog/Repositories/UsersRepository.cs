using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xblog.Repositories.Models;

namespace xblog.Repositories
{
  public class UsersRepository
  {
    private List<DbUser> _users;

    public UsersRepository()
    {
      _users = new List<DbUser>()
      {
          new DbUser()
        {
          Id = 1,
          Login = "OldGay",
          Pass = "QWE",
          FIO = "Sidorov O.V.",
          IsEdit = false
        },
        new DbUser()
        {
          Id = 2,
          Login = "Iamthelegend",
          Pass = "hui",
          FIO = "Ivanov I.I.",
          IsEdit = false
        },
        new DbUser()
        {
          Id = 3,
          Login = "HelloWorld",
          Pass = "FBI",
          FIO = "Kozlov G.P.",
          IsEdit = true
        },
        new DbUser()
        {
          Id = 4,
          Login = "NewHasl",
          Pass = "Privet",
          FIO = "Petrov H.S.",
          IsEdit = false
        },
        new DbUser()
        {
          Id = 5,
          Login = "Ihategoogle",
          Pass = "apple",
          FIO = "Tim Coock",
          IsEdit = true
        },
        new DbUser()
        {
          Id = 6,
          Login = "TheInvisibleMan",
          Pass = "Horse",
          FIO = "Grishin A.V.",
          IsEdit = true
        }
      };
    }

    public IList<DbUser> GetAllUsers()
    {
      return _users;
    }

    public DbUser GetUser(int id)
    {
      return _users.FirstOrDefault(s => s.Id == id);
    }

    public bool InsertUser(DbUser article)
    {
      _users.Add(article);
      return true;
    }
  }
}
