using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xblog.Services.Models
{
  public class UserComment
  {
    public int CommentId { get; set; }
    public int UserId { get; set; }
    public string FIO { get; set; }
    public string ArticleValue { get; set; }
    public string CommentValue { get; set; }
    public DateTime CommentValueDate { get; set; }
  }
}
