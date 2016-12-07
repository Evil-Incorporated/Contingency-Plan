using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contingency_Plan
{
    public enum HomePageButton { Open, Quit, Help, About, FiniteAutomataButton, GrammarButton, PushDownAutomataButton, TuringMachineButton, AutomataDisplay };

    public partial class HomePage : UserControl
    {

        private Timer invocationTimer = new Timer();

        public delegate void clickEventHandeler(object sender, EventArgs args);

        public event clickEventHandeler onUserOpenClicked;
        public event clickEventHandeler onUserQuitClicked;
        public event clickEventHandeler onUserHelpClicked;
        public event clickEventHandeler onUserAboutClicked;
        public event clickEventHandeler onUserFiniteAutomataButtonClicked;
        public event clickEventHandeler onUserGrammarButtonClicked;
        public event clickEventHandeler onUserPushDownAutomataButtonClicked;
        public event clickEventHandeler onUserTuringMachineButtonClicked;

        private HomePageButton clickedObject;

        private object clickSender;
        private EventArgs clickE;

        public HomePage()
        {
            InitializeComponent();
            invocationTimer.Tick += new EventHandler(invokeTimerEvent);
            invocationTimer.Interval = 200;
        }

        private void invokeTimerEvent(object sender, EventArgs e)
        {
            invocationTimer.Stop();
            switch (clickedObject)
            {
                case HomePageButton.Open:
                    onUserOpenClicked(clickSender, clickE);
                    break;
                case HomePageButton.Quit:
                    onUserAboutClicked(clickSender, clickE);
                    break;
                case HomePageButton.Help:
                    onUserHelpClicked(clickSender, clickE);
                    break;
                case HomePageButton.About:
                    onUserAboutClicked(clickSender, clickE);
                    break;
                case HomePageButton.FiniteAutomataButton:
                    onUserFiniteAutomataButtonClicked(clickSender, clickE);
                    break;
                case HomePageButton.GrammarButton:
                    onUserGrammarButtonClicked(clickSender, clickE);
                    break;
                case HomePageButton.PushDownAutomataButton:
                    onUserPushDownAutomataButtonClicked(clickSender, clickE);
                    break;
                case HomePageButton.TuringMachineButton:
                    onUserTuringMachineButtonClicked(clickSender, clickE);
                    break;
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            FileContextMenuStrip.Show(getShowLocationPont(sender));
        }

        private Point getShowLocationPont(object sender)
        {
            Point p = new Point();
            p.X = this.Location.X;
            p.Y = this.Location.Y;
            Control parent = this.Parent;
            while (parent != null)
            {
                p.X = p.X + parent.Location.X;
                p.Y = p.Y + parent.Location.Y;
                parent = parent.Parent;
            }
            p.X = p.X + ((Button)sender).Location.X;
            p.Y = p.Y + ((Button)sender).Location.Y + ((Button)sender).Size.Height;
            return p;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpContextMenuStrip.Show(getShowLocationPont(sender));
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onUserOpenClicked != null)
                startTimerExecution(HomePageButton.Open, sender, e);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onUserQuitClicked != null)
                startTimerExecution(HomePageButton.Quit, sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onUserHelpClicked != null)
                startTimerExecution(HomePageButton.Help, sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onUserAboutClicked != null)
                startTimerExecution(HomePageButton.About, sender, e);
        }

        private void FiniteAutomataButton_Click(object sender, EventArgs e)
        {
            if (onUserFiniteAutomataButtonClicked != null)
                startTimerExecution(HomePageButton.FiniteAutomataButton, sender, e);
        }

        private void GrammarButton_Click(object sender, EventArgs e)
        {
            if (onUserGrammarButtonClicked != null)
                startTimerExecution(HomePageButton.GrammarButton, sender, e);
        }

        private void PushDownAutomataButton_Click(object sender, EventArgs e)
        {
            if (onUserPushDownAutomataButtonClicked != null)
                startTimerExecution(HomePageButton.PushDownAutomataButton, sender, e);
        }

        private void TuringMachineButton_Click(object sender, EventArgs e)
        {
            if (onUserTuringMachineButtonClicked != null)
                startTimerExecution(HomePageButton.TuringMachineButton, sender, e);
        }

        private void startTimerExecution(HomePageButton clickedObject, object sender, EventArgs e)
        {
            if (!invocationTimer.Enabled)
            {
                clickSender = sender;
                clickE = e;
                this.clickedObject = clickedObject;
                invocationTimer.Start();
            }
        }

        public void disableFiniteAutomata()
        {
            finiteAutomataButton.Enabled = false;
        }
    }
}
