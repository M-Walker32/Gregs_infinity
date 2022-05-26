using System;
using System.ComponentModel.DataAnnotations;

namespace Gregs_infinity.Models
{
  public class Car
  {
    public int Id { get; set; }
    public string Model { get; set; }
    public string Make { get; set; }
    public string Body { get; set; }
    [Url]
    public string ImgUrl { get; set; }
    public int Price { get; set; }
    public string UserId { get; set; }
    public Account Creator { get; set; }
  }
}