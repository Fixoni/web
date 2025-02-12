using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw7.Models;

public class Game{
    public int Id{ get; set; }
    [DisplayName("Name")]
    [Required(ErrorMessage ="Nazwa jest wymagana")]
    public string? Name{ get; set; }
    [DisplayName("Firma")]
    [Required(ErrorMessage ="Firma jest wymagana")]
    public string? Firm{ get; set; }
    [DisplayName("Typ")]
    [Required(ErrorMessage ="Typ jest wymagany")]
    public string? Type{ get; set; }
    [DisplayName("Cena")]
    [Required(ErrorMessage ="Cena jest wymagana")]
    [Range(0,2000,ErrorMessage ="Cena musi być wieksza")]
    public double? Price{ get; set; }
}