using System;

namespace xblog.Repositories.Models
{
  public class DbArticle
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string ArticleValue { get; set; }
    public DateTime ArticleValueDate { get; set; }
  }
}
