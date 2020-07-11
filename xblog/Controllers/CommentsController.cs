using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using xblog.Controllers.Models;
using xblog.Services;
using xblog.Services.Models;

namespace xblog.Controllers
{
  [Route("api/Comments")]
  [ApiController]
  public class CommentsController : ControllerBase
  {
    private readonly CommentsService _commentsService;

    public CommentsController()
    {
      _commentsService = new CommentsService();
    }

    [HttpGet]
    [Route("GetNComments")]
    public IActionResult GetNComments([FromQuery]CreateNCommentsRequest comments)
    {
      var articleComments = _commentsService.GetNComments(comments.ArticleId, comments.CommentsCount, comments.PageNubmer);
      return Ok(articleComments);
    }

    [HttpDelete]
    [Route("DeleteComment")]
    public IActionResult DeleteComment(CreateCommentRequest comment)
    {
      var fillComment = new Comment { Id = comment.UserId, UserId = comment.UserId, CommentValue = comment.CommentValue, CommentValueDate = DateTime.Now, ArticleId = comment.ArticaleId };
      var deleteComment = _commentsService.DeleteComment(fillComment);
      return Ok(deleteComment);
    }
  }
  
}
