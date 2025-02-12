using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw7.Models;

public class Movie{
    public int Id{ get; set; }
    [DisplayName("Tytuł")]
    [Required(ErrorMessage ="Tytuł jest wymagany")]
    public string? Title{ get; set; }
    [DisplayName("Reżeyser")]
    [Required(ErrorMessage ="Reżyser jest wymagany")]
    public string? Director{ get; set; }
    [DisplayName("Data wydania:")]
    [Required(ErrorMessage ="Data jest wymagana")]
    public DateOnly ReleaseDate{ get; set; }
    [DisplayName("Gatunek")]
    [Required(ErrorMessage ="Gatunek jest wymagany")]
    public string? Genre{ get; set; }
    [DisplayName("Cena")]
    [Required(ErrorMessage ="Cena jest wymagana")]
    [Range(0,2000,ErrorMessage ="Cena musi być wieksza")]
    public double? Price{ get; set; }
}