using System.ComponentModel.DataAnnotations;

namespace Mooshak2.Models.Entities
{
    public class AssignmentLanguage
	{
        [Key]
        /// <summary>
        /// An unique ID number of a programming language.
        /// </summary>
        public int languageID { get; set; }

        /// <summary>
        /// Name of a programming language.
        /// </summary>
        public string name { get; set; }
	}
}