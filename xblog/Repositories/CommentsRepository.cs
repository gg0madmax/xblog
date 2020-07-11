using System;
using System.Collections.Generic;
using System.Linq;
using xblog.Repositories.Models;

namespace xblog.Repositories
{
  public class CommentsRepository
  {
    private List<DbComment> _comment;

    public CommentsRepository()
    {
      _comment = new List<DbComment>()
      {
        new DbComment()
        {
          Id = 1,
          ArticleId = 1,
          UserId = 1,
          CommentValue = "Первый нах",
          CommentValueDate = new DateTime(2020, 07, 01)
        },
        new DbComment()
        {
          Id = 2,
          ArticleId = 1,
          UserId = 2,
          CommentValue = "Статья не оч 2",
          CommentValueDate = new DateTime(2020, 07, 01)
        },
        new DbComment()
        {
          Id = 3,
          ArticleId = 1,
          UserId = 3,
          CommentValue = "Статья не оч 3",
          CommentValueDate = new DateTime(2020, 07, 01)
        },
        new DbComment()
        {
          Id = 4,
          ArticleId = 1,
          UserId = 4,
          CommentValue = "Статья не оч 4",
          CommentValueDate = new DateTime(2020, 07, 02)
        },
        new DbComment()
        {
          Id = 5,
          ArticleId = 1,
          UserId = 4,
          CommentValue = "Статья не оч 5",
          CommentValueDate = new DateTime(2020, 07, 02)
        },
        new DbComment()
        {
          Id = 6,
          ArticleId = 1,
          UserId = 5,
          CommentValue = "Статья не оч 6",
          CommentValueDate = new DateTime(2020, 07, 03)
        },
        new DbComment()
        {
          Id = 7,
          ArticleId = 1,
          UserId = 6,
          CommentValue = "Статья норм",
          CommentValueDate = new DateTime(2020, 07, 04)
        },
        new DbComment()
        {
          Id = 8,
          ArticleId = 1,
          UserId = 6,
          CommentValue = "Статья не оч 7",
          CommentValueDate = new DateTime(2020, 07, 05)
        },
        new DbComment()
        {
          Id = 9,
          ArticleId = 1,
          UserId = 1,
          CommentValue = "Статья не оч 8",
          CommentValueDate = new DateTime(2020, 07, 05)
        },
        new DbComment()
        {
          Id = 10,
          ArticleId = 1,
          UserId = 2,
          CommentValue = "Статья не оч 9",
          CommentValueDate = new DateTime(2020, 07, 06)
        },
        new DbComment()
        {
          Id = 11,
          ArticleId = 2,
          UserId = 2,
          CommentValue = "Збс статья",
          CommentValueDate = new DateTime(2020, 07, 01)
        },
        new DbComment()
        {
          Id = 12,
          ArticleId = 2,
          UserId = 6,
          CommentValue = "Статья не оч как тА",
          CommentValueDate = new DateTime(2020, 07, 05)
        }
      };
    }

    public IList<DbComment> GetAllComments()
    {
      return _comment;
    }

    public IEnumerable<DbComment> GetAllCommentsByArticleId(int id)
    {
      return _comment.Where(s => s.ArticleId == id);
    }

    public DbComment GetComment(int id)
    {
      return _comment.FirstOrDefault(s => s.Id == id);
    }

    public bool InsertComment(DbComment article)
    {
      _comment.Add(article);
      return true;
    }
    
    public bool DeleteComment(DbComment article)
    {
      _comment.Remove(article);
      return true;
    }
  }
}
