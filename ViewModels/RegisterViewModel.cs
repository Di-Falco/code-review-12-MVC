using System.ComponentModel.DataAnnotations;

namespace ParksMVC.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [Display(Name="Username")]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name="Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage="The password and confirmation password do not match")]
    public string ConfirmPassword { get; set; }
  }
}