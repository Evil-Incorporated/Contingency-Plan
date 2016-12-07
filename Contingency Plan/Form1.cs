using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contingency_Plan
{
    public partial class Form1 : MaterialForm
    {
        public int finiteAutomataTabNumber = 0;
		public int automataDisplayTabNumber = 0;

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void onOpen(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

   
   }

        private void onQuit(object sender, EventArgs e)
        {
            Console.WriteLine("Close");
        }

        private void onHelp(object sender, EventArgs e)
        {
            Console.WriteLine("Help");
        }

        private void onAbout(object sender, EventArgs e)
        {
            Console.WriteLine("About");
        }

        private void finiteAutomata_click(object sender, EventArgs e)
        {
            if (finiteAutomataTabNumber == 0)
            {
                FiniteAutomataPage finiteAutomata = (FiniteAutomataPage)createNewTab(new FiniteAutomataPage(), "Finite Automata", ref finiteAutomataTabNumber);
                finiteAutomata.onUserCloseClicked += new FiniteAutomataPage.clickEventHandeler(closeTab);
				finiteAutomata.onUserInputClicked += new FiniteAutomataPage.displayEventHandeler(openFiniteAutomataDisplayTab);
            }
            else
                materialTabControl1.SelectedIndex = finiteAutomataTabNumber;
        }

        private void grammar_click(object sender, EventArgs e)
        {
            Console.WriteLine("Grammar");
        }
        private void pushDownAutomata_click(object sender, EventArgs e)
        {
            Console.WriteLine("Pushdown Automata");
        }
        private void turingMachine_click(object sender, EventArgs e)
        {
            Console.WriteLine("Turing Machine");
        }

        private void closeTab(object sender, EventArgs e)
        {
			int returnTo = 0;
			if (materialTabControl1.SelectedIndex == finiteAutomataTabNumber)
				finiteAutomataTabNumber = 0;
			else if (materialTabControl1.SelectedIndex == automataDisplayTabNumber)
			{
				automataDisplayTabNumber = 0;
				returnTo = finiteAutomataTabNumber;
				materialTabSelector1.Enabled = true;
			}
            materialTabControl1.Controls.RemoveAt(materialTabControl1.SelectedIndex);
			materialTabControl1.SelectedIndex = returnTo;
        }

		private void openFiniteAutomataDisplayTab(GraphicState initialState, Bitmap backBuffer)
		{
			if (initialState != null)
			{
				Input inputForm = new Input();
				inputForm.StartPosition = FormStartPosition.CenterScreen;
				DialogResult res = inputForm.ShowDialog();
				if (res == DialogResult.OK)
				{
					AutomataDisplayPage display = (AutomataDisplayPage)createNewTab(new AutomataDisplayPage(initialState, backBuffer, inputForm.getText()), "Display", ref automataDisplayTabNumber);
					display.onUserCloseClick += new AutomataDisplayPage.clickEventHandler(closeTab);
					materialTabSelector1.Enabled = false;
				}
			}
			else
			{
				AutomataMessageBox error = new AutomataMessageBox("No initial state selected");
				error.StartPosition = FormStartPosition.CenterScreen;
				error.ShowDialog();
			}
		}

		public UserControl createNewTab(UserControl control, String tabName, ref int index)
		{
			
			TabPage newTab = new TabPage();
			newTab.SuspendLayout();
			materialTabControl1.Controls.Add(newTab);

			newTab.Controls.Add(control);
			newTab.Location = new System.Drawing.Point(4, 22);
			newTab.Name = tabName+"Tab";
			newTab.Padding = new System.Windows.Forms.Padding(3);
			newTab.Size = new System.Drawing.Size(505, 279);
			newTab.TabIndex = 1;
			newTab.Text = tabName;
			newTab.UseVisualStyleBackColor = true;

			control.Dock = System.Windows.Forms.DockStyle.Fill;
			control.Location = new System.Drawing.Point(3, 3);
			control.Name = tabName;
			control.Size = new System.Drawing.Size(499, 273);
			control.TabIndex = 0;

			newTab.ResumeLayout(false);

			//homePage.disableFiniteAutomata();
			MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.DARK;

			materialTabControl1.SelectedIndex = materialTabControl1.TabCount - 1;
			index = materialTabControl1.SelectedIndex;
			return control;
		}

        private void materialTabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex != 0)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

    }
}
