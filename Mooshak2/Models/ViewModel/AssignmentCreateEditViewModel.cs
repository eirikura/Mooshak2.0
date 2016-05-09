using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// This View shows the page where assignment are edited or created. Teacher will put in the name of the assignment,
    /// due date, description and the weight for the assignment. 100% if the assignment only has one part or he can
    /// assign 15% to the part so the assignment will add up to 100% in the end.
    /// </summary>
    public class AssignmentCreateEditViewModel
    {
        /// <summary>
        /// The name for the assignment.
        /// </summary>
        public string assignmentName { get; set; }

        /// <summary>
        /// Description for individual part of the assignment.
        /// </summary>
        public string partsDescription { get; set; }

        /// <summary>
        /// Due date for the assignment.
        /// </summary>
        public DateTime assignmentDueDate { get; set; }
    }
}