using System.ComponentModel.DataAnnotations;

namespace Mooshak2.Models.ViewModel
{
    public class CourseEditViewModel
    {
        /// <summary>
        /// The ID number of a course.
        /// </summary>
        public int courseID { get; set; }

        /// <summary>
        /// The name of a course.
        /// </summary>
        [Display(Name = "Course name")]
        [Required(ErrorMessage = "Course name is required")]
        public string courseName { get; set; }

        /// <summary>
        /// The description of a course.
        /// </summary>
        [Display(Description = "Course description")]
        public string courseDescription { get; set; }
    }
}