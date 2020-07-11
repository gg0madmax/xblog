using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xblog.Services.Models
{
  public class User
  {
    public int Id { get; set; }
    public string Login { get; set; }
    public string Pass { get; set; }
    public string FIO { get; set; }
  }
}
