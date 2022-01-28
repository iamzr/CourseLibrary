using CourseLibrary.API.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(
        ErrorMessage = "Title must be different from the description")]
    public abstract class CourseForManipulationDto
    { 
        [Required(ErrorMessage = "You should fill out the title")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage ="You need to fill out the description")]
        [MaxLength(1500, ErrorMessage = "The description shouldn't have more than 1500 characters")]
        public virtual string Description { get; set; }

    }
}
