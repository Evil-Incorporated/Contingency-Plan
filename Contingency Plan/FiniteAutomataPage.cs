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
    public partial class FiniteAutomataPage : UserControl
    {
        public delegate void clickEventHandeler(object sender, EventArgs e);
		public delegate void displayEventHandeler(GraphicState initialState,  Bitmap backBuffer);

        public event clickEventHandeler onUserCloseClicked;
		public event displayEventHandeler onUserInputClicked;

		//public int displayTabNumber = 0;

        public FiniteAutomataPage()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (onUserCloseClicked != null)
                onUserCloseClicked(sender, e);
        }

        private void FileButton_Click(object sender, EventArgs e)
        {

        }

		private void InputButton_Click(object sender, EventArgs e)
		{
			onUserInputClicked(automataUserControl1.getInitialState(), automataUserControl1.backBuffer);
		}
	}
}
