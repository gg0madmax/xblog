using System;
using Microsoft.AspNetCore.Mvc;
using xblog.Controllers.Models;
using xblog.Repositories.Models;
using xblog.Services;
using xblog.Services.Models;

namespace xblog.Controllers
{
  [Route("api/Articles")]
  [ApiController]
  public class ArticlesController : ControllerBase
  {
    private readonly ArticlesService _articlesService;

    public ArticlesController()
    {
      _articlesService = new ArticlesService();
    }

    [HttpGet]
    [Route("GetArticleById")]
    public IActionResult GetArticleById(int id)
    {
      var article = _articlesService.GetArticle(id);
      if (article == null)
      {
        return NotFound();
      }
      return Ok(article);
    }

    [HttpGet]
    [Route("GetUserArticlesByUserId")]
    public IActionResult GetUserArticlesByUserId(int id)
    {
      var articles = _articlesService.GetArticleByUserId(id);
      return Ok(articles);
    }

    [HttpGet]
    [Route("GetUserArticlesByDate")]
    public IActionResult GetUserArticlesByDate(DateTime date)
    {
      var articleUserList = _articlesService.GetUserArticleByDate(date);
      return Ok(articleUserList);
    }

    [HttpGet]
    [Route("AddArticle")]
    public IActionResult AddArticle(CreateArticleRequest article)
    {
      var fillArticle = new Article { Id = article.UserId, UserId = article.UserId, ArticleValue = article.ArticleValue, ArticleValueDate = DateTime.Now };
      var addArticle = _articlesService.AddArcticle(fillArticle);
      return Ok(addArticle);
    }
  }
}
