using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xblog.Services.Models
{
  public class Comment
  {
    public int Id { get; set; }
    public int ArticleId { get; set; }
    public int UserId { get; set; }
    public string CommentValue { get; set; }
    public DateTime CommentValueDate { get; set; }
  }
}
