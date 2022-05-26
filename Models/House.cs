using System;
using System.ComponentModel.DataAnnotations;

namespace Gregs_infinity.Models
{
  public class House
  {
    public int Id { get; set; }
    public string Address { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    [Url]
    public string ImgUrl { get; set; }
    public string UserId { get; set; }
  }
}