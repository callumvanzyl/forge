using Forge.Interfaces;
using Forge.Managers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Forge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InterfaceManager.Initiate();
        }
    }
}
