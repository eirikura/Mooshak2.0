using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.ViewModel
{
    public class AdminViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<AssignmentViewModel> latestChanges { get; set; }
    }
}