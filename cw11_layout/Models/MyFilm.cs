using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw11_layout.Models;

public class MyFilm
{
    public int Id { get; set; }
    
    [DisplayName("Tytuł filmu")]
    [Required(ErrorMessage = "Tytuł jest wymagany")]
    public string Title { get; set; }
    
    [DisplayName("Reżyser")]
    [Required(ErrorMessage = "Reżyser jest wymagany")]
    public string Director { get; set; }
    
    [DisplayName("Rok wydania")]
    [Required(ErrorMessage = "Rok wydania jest wymagany")]
    [Range(1888, 2100, ErrorMessage = "Rok musi być z przedziału 1888-2100")]
    public int? ReleaseYear { get; set; }
}