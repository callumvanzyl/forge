using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

using Forge.Managers;

namespace Forge.Interfaces
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        List<Action> preloadingActions = new List<Action> // A list of actions that must be carried out for the application to be considered ready.
        {
            () => TileManager.RefreshTileList()
        };

        private async void Splash_Load(object sender, EventArgs e)
        {
            int increment = fprgLoadApplication.Maximum / preloadingActions.Count; // Calculate the incremental value of each action.

            foreach (var a in preloadingActions)
            {
                await Task.Delay(250);
                a.Invoke();
                fprgLoadApplication.Increment(increment); // Increment the loading bar.
            }

            fprgLoadApplication.Value = fprgLoadApplication.Maximum;
            fprgLoadApplication.Color = Color.Green;

            await Task.Delay(1500);

            InterfaceManager.Preloaded();
        }
    }
}
