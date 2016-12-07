using System;

namespace Contingency_Plan
{
    partial class AutomataUserControl
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
			this.panel2 = new Contingency_Plan.DrawPanel();
			this.transitionTokenTextField = new System.Windows.Forms.TextBox();
			this.deleterRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
			this.transitionCreatorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
			this.stateCreatorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
			this.attributeEditorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
			this.StateContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
			this.initialStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.finalStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.StateContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.deleterRadioButton);
			this.panel1.Controls.Add(this.transitionCreatorRadioButton);
			this.panel1.Controls.Add(this.stateCreatorRadioButton);
			this.panel1.Controls.Add(this.attributeEditorRadioButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(462, 316);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.transitionTokenTextField);
			this.panel2.Location = new System.Drawing.Point(4, 34);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(455, 279);
			this.panel2.TabIndex = 4;
			// 
			// transitionTokenTextField
			// 
			this.transitionTokenTextField.Location = new System.Drawing.Point(4, 4);
			this.transitionTokenTextField.Name = "transitionTokenTextField";
			this.transitionTokenTextField.Size = new System.Drawing.Size(71, 20);
			this.transitionTokenTextField.TabIndex = 0;
			this.transitionTokenTextField.Visible = false;
			this.transitionTokenTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransitionTokenTextField_KeyPress);
			//this.transitionTokenTextField.LostFocus += new System.EventHandler(TransitionTokenTextField_LostFocus);
			// 
			// deleterRadioButton
			// 
			this.deleterRadioButton.AutoSize = true;
			this.deleterRadioButton.Depth = 0;
			this.deleterRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
			this.deleterRadioButton.Location = new System.Drawing.Point(374, 0);
			this.deleterRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.deleterRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
			this.deleterRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.deleterRadioButton.Name = "deleterRadioButton";
			this.deleterRadioButton.Ripple = true;
			this.deleterRadioButton.Size = new System.Drawing.Size(73, 30);
			this.deleterRadioButton.TabIndex = 3;
			this.deleterRadioButton.TabStop = true;
			this.deleterRadioButton.Text = "Deleter";
			this.deleterRadioButton.UseVisualStyleBackColor = true;
			this.deleterRadioButton.CheckedChanged += new System.EventHandler(radioButtonCheckChangedEvent);
			// 
			// transitionCreatorRadioButton
			// 
			this.transitionCreatorRadioButton.AutoSize = true;
			this.transitionCreatorRadioButton.Depth = 0;
			this.transitionCreatorRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
			this.transitionCreatorRadioButton.Location = new System.Drawing.Point(233, 0);
			this.transitionCreatorRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.transitionCreatorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
			this.transitionCreatorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.transitionCreatorRadioButton.Name = "transitionCreatorRadioButton";
			this.transitionCreatorRadioButton.Ripple = true;
			this.transitionCreatorRadioButton.Size = new System.Drawing.Size(141, 30);
			this.transitionCreatorRadioButton.TabIndex = 2;
			this.transitionCreatorRadioButton.TabStop = true;
			this.transitionCreatorRadioButton.Text = "Transition Creator";
			this.transitionCreatorRadioButton.UseVisualStyleBackColor = true;
			this.transitionCreatorRadioButton.CheckedChanged += new System.EventHandler(radioButtonCheckChangedEvent);
			// 
			// stateCreatorRadioButton
			// 
			this.stateCreatorRadioButton.AutoSize = true;
			this.stateCreatorRadioButton.Depth = 0;
			this.stateCreatorRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
			this.stateCreatorRadioButton.Location = new System.Drawing.Point(123, 0);
			this.stateCreatorRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.stateCreatorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
			this.stateCreatorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.stateCreatorRadioButton.Name = "stateCreatorRadioButton";
			this.stateCreatorRadioButton.Ripple = true;
			this.stateCreatorRadioButton.Size = new System.Drawing.Size(110, 30);
			this.stateCreatorRadioButton.TabIndex = 1;
			this.stateCreatorRadioButton.TabStop = true;
			this.stateCreatorRadioButton.Text = "State Creator";
			this.stateCreatorRadioButton.UseVisualStyleBackColor = true;
			this.stateCreatorRadioButton.CheckedChanged += new System.EventHandler(radioButtonCheckChangedEvent);
			// 
			// attributeEditorRadioButton
			// 
			this.attributeEditorRadioButton.AutoSize = true;
			this.attributeEditorRadioButton.Checked = true;
			this.attributeEditorRadioButton.Depth = 0;
			this.attributeEditorRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
			this.attributeEditorRadioButton.Location = new System.Drawing.Point(0, 0);
			this.attributeEditorRadioButton.Margin = new System.Windows.Forms.Padding(0);
			this.attributeEditorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
			this.attributeEditorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.attributeEditorRadioButton.Name = "attributeEditorRadioButton";
			this.attributeEditorRadioButton.Ripple = true;
			this.attributeEditorRadioButton.Size = new System.Drawing.Size(123, 30);
			this.attributeEditorRadioButton.TabIndex = 0;
			this.attributeEditorRadioButton.TabStop = true;
			this.attributeEditorRadioButton.Text = "Attribute Editor";
			this.attributeEditorRadioButton.UseVisualStyleBackColor = true;
			this.attributeEditorRadioButton.CheckedChanged += new System.EventHandler(radioButtonCheckChangedEvent);
			// 
			// StateContextMenuStrip
			// 
			this.StateContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.StateContextMenuStrip.Depth = 0;
			this.StateContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initialStateToolStripMenuItem,
            this.finalStateToolStripMenuItem});
			this.StateContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
			this.StateContextMenuStrip.Name = "materialContextMenuStrip1";
			this.StateContextMenuStrip.Size = new System.Drawing.Size(153, 70);
			// 
			// initialStateToolStripMenuItem
			// 
			this.initialStateToolStripMenuItem.Name = "initialStateToolStripMenuItem";
			this.initialStateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.initialStateToolStripMenuItem.Text = "Initial State";
			this.initialStateToolStripMenuItem.Click += new System.EventHandler(this.initialStateToolStripMenuItem_Click);
			// 
			// finialStateToolStripMenuItem
			// 
			this.finalStateToolStripMenuItem.Name = "finialStateToolStripMenuItem";
			this.finalStateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.finalStateToolStripMenuItem.Text = "Final State";
			this.finalStateToolStripMenuItem.Click += new System.EventHandler(this.finalStateToolStripMenuItem_Click);
			// 
			// AutomataUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			//this.ContextMenuStrip = this.StateContextMenuStrip;
			this.Controls.Add(this.panel1);
			this.Name = "AutomataUserControl";
			this.Size = new System.Drawing.Size(462, 316);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.StateContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		private void radioButtonCheckChangedEvent(object sender, EventArgs e)
		{
			getTextFieldData();
		}

		#endregion

		private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRadioButton deleterRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton transitionCreatorRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton stateCreatorRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton attributeEditorRadioButton;
		private DrawPanel panel2;
		private System.Windows.Forms.TextBox transitionTokenTextField;
		private MaterialSkin.Controls.MaterialContextMenuStrip StateContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem initialStateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem finalStateToolStripMenuItem;
	}
}
