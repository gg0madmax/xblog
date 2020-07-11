using System;
using System.Collections.Generic;
using System.Linq;
using xblog.Repositories;
using xblog.Repositories.Models;
using xblog.Services.Models;

namespace xblog.Services
{
  public class ArticlesService
  {
    private readonly ArticlesRepository _articlesRepository;
    private readonly CommentsRepository _commentsRepository;
    private readonly UsersRepository _usersRepository;

    public ArticlesService()
    {
      _articlesRepository = new ArticlesRepository();
      _commentsRepository = new CommentsRepository();
      _usersRepository = new UsersRepository();
    }

    public List<UserComment> GetArticleComments(int id)
    {
      var userCommentList = new List<UserComment>();
      var dbComments = _commentsRepository.GetAllCommentsByArticleId(id);
      foreach (var dbComment in dbComments)
      {
        var dbArticles = _articlesRepository.GetArticle(dbComment.ArticleId);
        var dbUser = _usersRepository.GetUser(dbArticles.UserId);
        userCommentList.Add(new UserComment { CommentId = dbComment.Id, UserId = dbComment.UserId, FIO = dbUser.FIO, ArticleValue = dbArticles.ArticleValue, CommentValue = dbComment.CommentValue, CommentValueDate = dbComment.CommentValueDate });
      }
      return userCommentList;
    }

    public ArticleUser GetArticle(int id)
    {
      var dbArticle = _articlesRepository.GetArticle(id);
      var dbUser = _usersRepository.GetUser(dbArticle.UserId);
      var article = new ArticleUser { Id = dbArticle.Id, ArticleValue = dbArticle.ArticleValue, ArticleValueDate = dbArticle.ArticleValueDate, FIO = dbUser.FIO };
      return article;
    }

    public IEnumerable<ArticleUser> GetArticleByUserId(int id)
    {
      var dbUser = _usersRepository.GetUser(id);
      var dbArticle = _articlesRepository.GetAllArticlesByUserId(id).Select(s => new ArticleUser() { Id = s.Id, ArticleValue = s.ArticleValue, ArticleValueDate = s.ArticleValueDate, FIO = dbUser.FIO });
      return dbArticle;
    }

    public IEnumerable<ArticleUser> GetUserArticleByDate(DateTime date)
    {
      var articleUserList = new List<ArticleUser>();
      var dbArticles = _articlesRepository.GetAllArticlesByDate(date);
      foreach (var dbArticle in dbArticles)
      {
        var dbUser = _usersRepository.GetUser(dbArticle.UserId);
        articleUserList.Add(new ArticleUser
        {
          Id = dbArticle.Id,
          ArticleValue = dbArticle.ArticleValue,
          ArticleValueDate = dbArticle.ArticleValueDate,
          FIO = dbUser.FIO
        });
      }
      return articleUserList;
    }

    public bool AddArcticle(Article article)
    {
      var newId = _articlesRepository.GetAllArticles().Max(s => s.Id) + 1;
      var fillArticle = new DbArticle { Id = newId, UserId = article.UserId, ArticleValue = article.ArticleValue, ArticleValueDate = DateTime.Now };
      var dbArticleAdd = _articlesRepository.InsertArticle(fillArticle);
      return dbArticleAdd;
    }
  }
}
