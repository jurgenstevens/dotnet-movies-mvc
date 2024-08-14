using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Review
{
  public int Id { get; set; }
  public string? Content { get; set; }
}