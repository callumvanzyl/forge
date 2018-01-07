using System.Windows.Forms;
using Forge.Interfaces;

namespace Forge.Managers
{
    public static class InterfaceManager
    {
        public static Splash splashWindow;
        public static Editor editorWindow;

        public static void Initiate() // At runtime...
        {
            splashWindow = new Interfaces.Splash();
            editorWindow = new Interfaces.Editor();
            Application.Run(splashWindow); // The splash window is the main window!
        }

        public static void Preloaded() // Hides the splash window and shows the editor window.
        {
            splashWindow.Hide();
            editorWindow.Show();
        }
    }
}
