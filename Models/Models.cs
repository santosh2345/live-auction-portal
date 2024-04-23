
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


// this is model for register user
public class RegisterViewModel
{
    [Required]
    [Display(Name = "User Type")]
    public string UserType { get; set; }

     [Required]
    [Display(Name = "Username")]
    public string Username { get; set; }

    [Required]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [Required]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; }
}