namespace Mooshak2.Models.ViewModel
{
    /// <summary>
    /// The frontpage of the whole website. It is required to log in to the system in orded to be 
    /// able to perform any action within the system. The users available actions depend on the users 
    /// assigned role.
    /// </summary>
    public class LogInViewModel
    {
        /// <summary>
        /// Used to get the users username, for the log in process.
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Used to get the users password, for the log in process.
        /// </summary>
        public string password { get; set; }
    }
}