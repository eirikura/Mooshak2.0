namespace Mooshak2.Models.Entities
{
    /// <summary>
    /// It is possible to divide an assignment into many parts with different weight for each,
    /// every assignment has at least one part or more.
    /// Example: An assignment named Project 3 is divided into two parts each weighing 50%.
    /// </summary>
    public class AssignmentParts
    {
        /// <summary>
        /// An unique auto-generated ID number of a part.
        /// </summary>
        public int partsID { get; set; }

        /// <summary>
        /// An unique ID used to connect a part with an assignment.
        /// </summary>
        public int assigmentID { get; set; }

        /// <summary>
        /// A name(title) of a part.
        /// </summary>
        public string partsName { get; set; }

        /// <summary>
        /// A description of a part.
        /// </summary>
        public string partsDescription { get; set; }

        /// <summary>
        /// The weight of a part in percentages.
        /// Example: An assignment is divided into two parts, each having 50% weight(percentage).
        /// </summary>
        public int percentage { get; set; }
    }
}