namespace Contingency_Plan
{
    partial class FiniteAutomataPage
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.automataUserControl1 = new Contingency_Plan.AutomataUserControl();
			this.TestButton = new MaterialSkin.Controls.MaterialFlatButton();
			this.InputButton = new MaterialSkin.Controls.MaterialFlatButton();
			this.FileButton = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.automataUserControl1);
			this.panel1.Controls.Add(this.TestButton);
			this.panel1.Controls.Add(this.InputButton);
			this.panel1.Controls.Add(this.FileButton);
			this.panel1.Controls.Add(this.materialRaisedButton1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 295);
			this.panel1.TabIndex = 0;
			// 
			// automataUserControl1
			// 
			this.automataUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.automataUserControl1.Location = new System.Drawing.Point(4, 52);
			this.automataUserControl1.Name = "automataUserControl1";
			this.automataUserControl1.Size = new System.Drawing.Size(469, 240);
			this.automataUserControl1.TabIndex = 4;
			// 
			// TestButton
			// 
			this.TestButton.AutoSize = true;
			this.TestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TestButton.Depth = 0;
			this.TestButton.Location = new System.Drawing.Point(111, 6);
			this.TestButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TestButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.TestButton.Name = "TestButton";
			this.TestButton.Primary = false;
			this.TestButton.Size = new System.Drawing.Size(45, 36);
			this.TestButton.TabIndex = 3;
			this.TestButton.Text = "Test";
			this.TestButton.UseVisualStyleBackColor = true;
			// 
			// InputButton
			// 
			this.InputButton.AutoSize = true;
			this.InputButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.InputButton.Depth = 0;
			this.InputButton.Location = new System.Drawing.Point(51, 6);
			this.InputButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.InputButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.InputButton.Name = "InputButton";
			this.InputButton.Primary = false;
			this.InputButton.Size = new System.Drawing.Size(52, 36);
			this.InputButton.TabIndex = 2;
			this.InputButton.Text = "Input";
			this.InputButton.UseVisualStyleBackColor = true;
			this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
			// 
			// FileButton
			// 
			this.FileButton.AutoSize = true;
			this.FileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.FileButton.Depth = 0;
			this.FileButton.Location = new System.Drawing.Point(4, 6);
			this.FileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.FileButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.FileButton.Name = "FileButton";
			this.FileButton.Primary = false;
			this.FileButton.Size = new System.Drawing.Size(39, 36);
			this.FileButton.TabIndex = 1;
			this.FileButton.Text = "File";
			this.FileButton.UseVisualStyleBackColor = true;
			this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
			// 
			// materialRaisedButton1
			// 
			this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialRaisedButton1.Depth = 0;
			this.materialRaisedButton1.Location = new System.Drawing.Point(451, 0);
			this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton1.Name = "materialRaisedButton1";
			this.materialRaisedButton1.Primary = true;
			this.materialRaisedButton1.Size = new System.Drawing.Size(25, 29);
			this.materialRaisedButton1.TabIndex = 0;
			this.materialRaisedButton1.Text = "✘";
			this.materialRaisedButton1.UseVisualStyleBackColor = true;
			this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
			// 
			// FiniteAutomataPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "FiniteAutomataPage";
			this.Size = new System.Drawing.Size(476, 295);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton TestButton;
        private MaterialSkin.Controls.MaterialFlatButton InputButton;
        private MaterialSkin.Controls.MaterialFlatButton FileButton;
		private AutomataUserControl automataUserControl1;
	}
}
