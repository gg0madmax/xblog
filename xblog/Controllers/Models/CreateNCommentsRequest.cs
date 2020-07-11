using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xblog.Controllers.Models
{
  public class CreateNCommentsRequest
  {
    public int ArticleId { get; set; }
    public int CommentsCount { get; set; }
    public int PageNubmer { get; set; }
  }
}
