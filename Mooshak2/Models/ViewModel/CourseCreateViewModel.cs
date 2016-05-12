using System.ComponentModel.DataAnnotations;

namespace Mooshak2.Models.ViewModel
{
    public class CourseCreateViewModel
    {
        /// <summary>
        /// Name of a course.
        /// </summary>
        [Display(Name = "Course name")]
        [Required(ErrorMessage = "Course name is required")]
        public string courseName { get; set; }

        /// <summary>
        /// Description of a course.
        /// </summary>
        [Display(Description = "Course description")]
        public string courseDescription { get; set; }
    }
}