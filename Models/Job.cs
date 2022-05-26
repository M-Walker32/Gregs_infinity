using System;
using System.ComponentModel.DataAnnotations;

namespace Gregs_infinity.Models
{
  public class Job
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public int Pay { get; set; }
    public string Description { get; set; }
    [Url]
    public string ImgUrl { get; set; }
    public string UserId { get; set; }
  }
}