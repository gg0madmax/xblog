using System;

namespace xblog.Repositories.Models
{
  public class DbUser
  {
    public int Id { get; set; }
    public string Login { get; set; }
    public string Pass { get; set; }
    public string FIO { get; set; }
    public bool IsEdit { get; set; }
  }
}
