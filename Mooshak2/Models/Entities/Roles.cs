namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// Roles are used to divide users into groups, each role having different abilities
    /// and rights within the system.
    /// There are a total of three main role groups: Admins, Teachers and Students.
    /// All the gropus are stored within this entity.
    /// Example: Admins can add new courses and new users while teachers and students cannot.
    /// </summary>
    public class Roles
    {
        /// <summary>
        /// An unique auto-generated ID number of a role.
        /// </summary>
        public int roleID { get; set; }

        /// <summary>
        /// A name(title) of a role.
        /// </summary>
        public string name { get; set; }

   }
}