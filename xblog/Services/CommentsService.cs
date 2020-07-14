using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using xblog.Controllers.Models;
using xblog.Repositories;
using xblog.Repositories.Models;
using xblog.Services.Models;

namespace xblog.Services
{
  public class CommentsService
  {
    private readonly ArticlesRepository _articlesRepository;
    private readonly CommentsRepository _commentsRepository;
    private readonly UsersRepository _usersRepository;

    public CommentsService()
    {
      _articlesRepository = new ArticlesRepository();
      _commentsRepository = new CommentsRepository();
      _usersRepository = new UsersRepository();
    }

    public UserComment GetComment(int id)
    {
      var dbComment = _commentsRepository.GetComment(id);
      var dbUser = _usersRepository.GetUser(dbComment.UserId);
      var dbArticle = _articlesRepository.GetArticle(dbComment.ArticleId);
      var comment = new UserComment { UserId = dbUser.Id, FIO = dbUser.FIO, ArticleValue = dbArticle.ArticleValue, CommentId = dbComment.Id, CommentValue = dbComment.CommentValue, CommentValueDate = dbComment.CommentValueDate };
      return comment;
    }

    public IEnumerable<UserComment> GetCommentByArticleId(int articleId)
    {
      var dbArticle = _articlesRepository.GetArticle(articleId);
      var dbUser = _usersRepository.GetUser(dbArticle.UserId);
      var dbComments = _commentsRepository.GetAllCommentsByArticleId(articleId).Select(s => new UserComment() { CommentId = s.Id, ArticleValue = dbArticle.ArticleValue, UserId = s.UserId, FIO = dbUser.FIO, CommentValue = s.CommentValue, CommentValueDate = s.CommentValueDate });
      return dbComments;
    }

    public IEnumerable<NComments> GetNComments(int articleId, int commentsCount, int pageNubmer)
    {
      var dbGetNComments = _commentsRepository.GetAllCommentsByArticleId(articleId)
        .Skip((pageNubmer - 1) * commentsCount)
        .Take(commentsCount)
        .Select(s => new NComments() { ArticleId = articleId, CommentValue = s.CommentValue, CommentValueDate = s.CommentValueDate });
      return dbGetNComments;
    }

    public bool DeleteComment(Comment comment)
    {
      var dbArticle = _articlesRepository.GetArticle(comment.ArticleId);
      var fillComment = new DbComment 
      {
        Id = comment.Id,
        UserId = comment.UserId,
        CommentValue = comment.CommentValue,
        CommentValueDate = comment.CommentValueDate,
        ArticleId = dbArticle.Id
      };
      var dbCommentDelete = _commentsRepository.DeleteComment(fillComment);
      return dbCommentDelete;
    }

  }
}
