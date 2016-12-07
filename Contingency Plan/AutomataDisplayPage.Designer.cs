using System.Drawing;

namespace Contingency_Plan
{
	partial class AutomataDisplayPage
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.closeButton = new MaterialSkin.Controls.MaterialRaisedButton();
			this.drawPanel1 = new Contingency_Plan.DrawPanel();
			this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.Depth = 0;
			this.closeButton.Location = new System.Drawing.Point(403, 0);
			this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.closeButton.Name = "closeButton";
			this.closeButton.Primary = true;
			this.closeButton.Size = new System.Drawing.Size(25, 29);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "✘";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// drawPanel1
			// 
			this.drawPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.drawPanel1.AutoScroll = true;
			this.drawPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.drawPanel1.Location = new System.Drawing.Point(3, 35);
			this.drawPanel1.Name = "drawPanel1";
			this.drawPanel1.Size = new System.Drawing.Size(422, 244);
			this.drawPanel1.TabIndex = 2;
			this.drawPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel1_Paint);
			// 
			// materialRaisedButton1
			// 
			this.materialRaisedButton1.Depth = 0;
			this.materialRaisedButton1.Location = new System.Drawing.Point(3, 3);
			this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton1.Name = "materialRaisedButton1";
			this.materialRaisedButton1.Primary = true;
			this.materialRaisedButton1.Size = new System.Drawing.Size(75, 26);
			this.materialRaisedButton1.TabIndex = 3;
			this.materialRaisedButton1.Text = "next";
			this.materialRaisedButton1.UseVisualStyleBackColor = true;
			this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
			// 
			// materialCheckBox1
			// 
			this.materialCheckBox1.AutoSize = true;
			this.materialCheckBox1.Depth = 0;
			this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox1.Location = new System.Drawing.Point(81, 2);
			this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox1.Name = "materialCheckBox1";
			this.materialCheckBox1.Ripple = true;
			this.materialCheckBox1.Size = new System.Drawing.Size(122, 30);
			this.materialCheckBox1.TabIndex = 4;
			this.materialCheckBox1.Text = "Text to Speech";
			this.materialCheckBox1.UseVisualStyleBackColor = true;
			// 
			// AutomataDisplayPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.materialCheckBox1);
			this.Controls.Add(this.materialRaisedButton1);
			this.Controls.Add(this.drawPanel1);
			this.Controls.Add(this.closeButton);
			this.Name = "AutomataDisplayPage";
			this.Size = new System.Drawing.Size(428, 282);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		

		#endregion

		private MaterialSkin.Controls.MaterialRaisedButton closeButton;
		private DrawPanel drawPanel1;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
	}
}
