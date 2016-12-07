using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contingency_Plan
{
	public partial class Input : MaterialForm
	{
		public Input()
		{
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}

		public String getText()
		{
			return materialSingleLineTextField1.Text;
		}
	}
}
