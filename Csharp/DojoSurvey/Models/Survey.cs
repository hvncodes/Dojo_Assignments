using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
        [MaxLength(20, ErrorMessage = "must be 20 characters or fewer.")]
        [Display(Name = "Your Name:")]
        public string Name {get;set;}

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Dojo Location:")]
        public string Location {get;set;}

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Favorite Language:")]
        public string Language {get;set;}

        [MaxLength(20, ErrorMessage = "must be 20 characters or fewer.")]
        [Display(Name = "Comment (optional):")]
        public string Comment {get;set;}
    }
}