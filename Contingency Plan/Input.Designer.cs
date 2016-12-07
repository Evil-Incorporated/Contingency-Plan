namespace Contingency_Plan
{
	partial class Input
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.SuspendLayout();
			// 
			// materialSingleLineTextField1
			// 
			this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialSingleLineTextField1.Depth = 0;
			this.materialSingleLineTextField1.Hint = "";
			this.materialSingleLineTextField1.Location = new System.Drawing.Point(39, 80);
			this.materialSingleLineTextField1.MaxLength = 32767;
			this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
			this.materialSingleLineTextField1.PasswordChar = '\0';
			this.materialSingleLineTextField1.SelectedText = "";
			this.materialSingleLineTextField1.SelectionLength = 0;
			this.materialSingleLineTextField1.SelectionStart = 0;
			this.materialSingleLineTextField1.Size = new System.Drawing.Size(218, 23);
			this.materialSingleLineTextField1.TabIndex = 0;
			this.materialSingleLineTextField1.TabStop = false;
			this.materialSingleLineTextField1.UseSystemPasswordChar = false;
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.materialFlatButton1.Location = new System.Drawing.Point(129, 112);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(30, 36);
			this.materialFlatButton1.TabIndex = 1;
			this.materialFlatButton1.Text = "Ok";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			// 
			// Input
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 174);
			this.Controls.Add(this.materialFlatButton1);
			this.Controls.Add(this.materialSingleLineTextField1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Input";
			this.Sizable = false;
			this.Text = "Input";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
	}
}