using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBookstore.Models;


public class Reader
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }

    [Display(Name = "Birth Date")]
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
    public string? email { get; set; }
  
}
