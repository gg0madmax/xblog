using System;
using System.Collections.Generic;
using System.Linq;
using xblog.Repositories.Models;

namespace xblog.Repositories
{
  public class ArticlesRepository
  {
    private List<DbArticle> _articles;

    public ArticlesRepository()
    {
      _articles = new List<DbArticle>()
      {
        new DbArticle()
        {
          Id = 1,
          UserId = 1,
          ArticleValue = "Статья 1",
          ArticleValueDate = new DateTime(2020, 07, 04)
        },
        new DbArticle()
        {
          Id = 2,
          UserId = 1,
          ArticleValue = "Статья 2",
          ArticleValueDate = new DateTime(2020, 07, 10)
        },
        new DbArticle()
        {
          Id = 3,
          UserId = 2,
          ArticleValue = "Статья 3",
          ArticleValueDate = new DateTime(2020, 07, 10)
        }
      };
    }

    public IList<DbArticle> GetAllArticles()
    {
      return _articles;
    }

    public IEnumerable<DbArticle> GetAllArticlesByUserId(int id) 
    {
      return _articles.Where(s => s.UserId == id);
    }

    public DbArticle GetArticle(int id)
    {
      return _articles.FirstOrDefault(s => s.Id == id);
    }

    public IEnumerable<DbArticle>GetAllArticlesByDate(DateTime date)
    {
      return _articles.Where(s => s.ArticleValueDate <= date);
    }

    public bool InsertArticle(DbArticle article)
    {
      _articles.Add(article);
      return true;
    }
  }
}
