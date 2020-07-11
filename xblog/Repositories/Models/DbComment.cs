using System;

namespace xblog.Repositories.Models
{
  public class DbComment
  {
    public int Id { get; set; }
    public int ArticleId { get; set; }
    public int UserId { get; set; }
    public string CommentValue { get; set; }
    public DateTime CommentValueDate { get; set; }
  }

}
