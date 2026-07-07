using System;
using System.Windows.Forms;

namespace SkillsInternationalSchool
{
    /// <summary>
    /// Entry point for the Skills International School Student Management System.
    /// Launches the LoginForm as the startup form.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for a modern look
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with the LoginForm
            Application.Run(new LoginForm());
        }
    }
}
