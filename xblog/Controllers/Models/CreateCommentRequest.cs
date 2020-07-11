using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xblog.Controllers.Models
{
  public class CreateCommentRequest
  {
    public int ArticaleId { get; set; }
    public int UserId { get; set; }
    public string CommentValue { get; set; }
  }
}
