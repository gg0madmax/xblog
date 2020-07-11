using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xblog.Controllers.Models
{
  public class CreateArticleRequest
  {
    public string ArticleValue { get; set; }
    public int UserId { get; set; }
  }
}
