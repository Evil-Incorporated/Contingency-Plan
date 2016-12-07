namespace Contingency_Plan
{
	partial class AutomataMessageBox
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
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.SuspendLayout();
			// 
			// materialLabel1
			// 
			this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(12, 84);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(108, 19);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "materialLabel1";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.materialFlatButton1.Location = new System.Drawing.Point(79, 109);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(30, 36);
			this.materialFlatButton1.TabIndex = 1;
			this.materialFlatButton1.Text = "Ok";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			// 
			// AutomataMessageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(193, 156);
			this.Controls.Add(this.materialFlatButton1);
			this.Controls.Add(this.materialLabel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AutomataMessageBox";
			this.Sizable = false;
			this.Text = "Message";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
	}
}