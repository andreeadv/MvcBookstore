using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBookstore.Models;


public class Section
{
    public int Id { get; set; }
    public string? Domain { get; set; }
    public int Hall { get; set; }

}