namespace Contingency_Plan
{
    partial class HomePage
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
            this.grammarButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.turingMachineButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pushDownAutomataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.finiteAutomataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.helpButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.fileButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.FileContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.FileContextMenuStrip.SuspendLayout();
            this.HelpContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grammarButton);
            this.panel1.Controls.Add(this.turingMachineButton);
            this.panel1.Controls.Add(this.pushDownAutomataButton);
            this.panel1.Controls.Add(this.finiteAutomataButton);
            this.panel1.Controls.Add(this.helpButton);
            this.panel1.Controls.Add(this.fileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 284);
            this.panel1.TabIndex = 0;
            // 
            // grammarButton
            // 
            this.grammarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grammarButton.Depth = 0;
            this.grammarButton.Location = new System.Drawing.Point(69, 117);
            this.grammarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.grammarButton.Name = "grammarButton";
            this.grammarButton.Primary = true;
            this.grammarButton.Size = new System.Drawing.Size(335, 43);
            this.grammarButton.TabIndex = 6;
            this.grammarButton.Text = "Grammar";
            this.grammarButton.UseVisualStyleBackColor = true;
            this.grammarButton.Click += new System.EventHandler(this.GrammarButton_Click);
            // 
            // turingMachineButton
            // 
            this.turingMachineButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.turingMachineButton.Depth = 0;
            this.turingMachineButton.Location = new System.Drawing.Point(69, 215);
            this.turingMachineButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.turingMachineButton.Name = "turingMachineButton";
            this.turingMachineButton.Primary = true;
            this.turingMachineButton.Size = new System.Drawing.Size(335, 43);
            this.turingMachineButton.TabIndex = 5;
            this.turingMachineButton.Text = "Turing Machine";
            this.turingMachineButton.UseVisualStyleBackColor = true;
            this.turingMachineButton.Click += new System.EventHandler(this.TuringMachineButton_Click);
            // 
            // pushDownAutomataButton
            // 
            this.pushDownAutomataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pushDownAutomataButton.Depth = 0;
            this.pushDownAutomataButton.Location = new System.Drawing.Point(69, 166);
            this.pushDownAutomataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pushDownAutomataButton.Name = "pushDownAutomataButton";
            this.pushDownAutomataButton.Primary = true;
            this.pushDownAutomataButton.Size = new System.Drawing.Size(335, 43);
            this.pushDownAutomataButton.TabIndex = 4;
            this.pushDownAutomataButton.Text = "PushDown Automata";
            this.pushDownAutomataButton.UseVisualStyleBackColor = true;
            this.pushDownAutomataButton.Click += new System.EventHandler(this.PushDownAutomataButton_Click);
            // 
            // finiteAutomataButton
            // 
            this.finiteAutomataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finiteAutomataButton.Depth = 0;
            this.finiteAutomataButton.Location = new System.Drawing.Point(69, 68);
            this.finiteAutomataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.finiteAutomataButton.Name = "finiteAutomataButton";
            this.finiteAutomataButton.Primary = true;
            this.finiteAutomataButton.Size = new System.Drawing.Size(335, 43);
            this.finiteAutomataButton.TabIndex = 2;
            this.finiteAutomataButton.Text = "Finite Automata";
            this.finiteAutomataButton.UseVisualStyleBackColor = true;
            this.finiteAutomataButton.Click += new System.EventHandler(this.FiniteAutomataButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = true;
            this.helpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpButton.Depth = 0;
            this.helpButton.Location = new System.Drawing.Point(51, 6);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpButton.Name = "helpButton";
            this.helpButton.Primary = false;
            this.helpButton.Size = new System.Drawing.Size(46, 36);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "HELP";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // fileButton
            // 
            this.fileButton.AutoSize = true;
            this.fileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileButton.Depth = 0;
            this.fileButton.Location = new System.Drawing.Point(4, 6);
            this.fileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileButton.Name = "fileButton";
            this.fileButton.Primary = false;
            this.fileButton.Size = new System.Drawing.Size(39, 36);
            this.fileButton.TabIndex = 0;
            this.fileButton.Text = "FILE";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // FileContextMenuStrip
            // 
            this.FileContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileContextMenuStrip.Depth = 0;
            this.FileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.FileContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileContextMenuStrip.Name = "FileContextMenuStrip";
            this.FileContextMenuStrip.Size = new System.Drawing.Size(98, 48);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // HelpContextMenuStrip
            // 
            this.HelpContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HelpContextMenuStrip.Depth = 0;
            this.HelpContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.HelpContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.HelpContextMenuStrip.Name = "HelpContextMenuStrip";
            this.HelpContextMenuStrip.Size = new System.Drawing.Size(108, 48);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(456, 284);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FileContextMenuStrip.ResumeLayout(false);
            this.HelpContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton fileButton;
        private MaterialSkin.Controls.MaterialRaisedButton turingMachineButton;
        private MaterialSkin.Controls.MaterialRaisedButton pushDownAutomataButton;
        private MaterialSkin.Controls.MaterialRaisedButton finiteAutomataButton;
        private MaterialSkin.Controls.MaterialFlatButton helpButton;
        private MaterialSkin.Controls.MaterialRaisedButton grammarButton;
        private MaterialSkin.Controls.MaterialContextMenuStrip FileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip HelpContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
