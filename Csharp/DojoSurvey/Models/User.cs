using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models
{
    public class User
    {
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
        [MaxLength(20, ErrorMessage = "must be 20 characters or fewer.")]
        public string FirstName {get;set;}

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
        [MaxLength(20, ErrorMessage = "must be 20 characters or fewer.")]
        public string LastName {get;set;}

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
        [MaxLength(20, ErrorMessage = "must be 20 characters or fewer.")]
        public string Username {get;set;}
        
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        
        [Required(ErrorMessage = "is required.")]
        [MinLength(8, ErrorMessage = "must be at least 8 characters.")]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [Required(ErrorMessage = "is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "must match Password.")]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm {get;set;}
    }
}