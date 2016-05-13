using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class AssignmentLanguageViewModel
    {
        /// <summary>
        /// The ID number of a programming language.
        /// </summary>
        public int languageID { get; set; }

        /// <summary>
        /// The name of a programming language.
        /// </summary>
        public string name { get; set; }
    }
}