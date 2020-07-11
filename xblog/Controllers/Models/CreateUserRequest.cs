using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xblog.Controllers.Models
{
  public class CreateUserRequest
  {
    public string Login { get; set; }
    public string Pass { get; set; }
    public string FIO { get; set; }
    public bool IsEdit { get; set; }
  }
}
