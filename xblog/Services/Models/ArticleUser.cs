using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xblog.Services.Models
{
  public class ArticleUser
  {
    public int Id { get; set; }
    public string ArticleValue { get; set; }
    public DateTime ArticleValueDate { get; set; }
    public string FIO { get; set; }
  }
}
