using System;

namespace Contingency_Plan
{
    partial class Form1
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
			this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
			this.homePageTab = new System.Windows.Forms.TabPage();
			this.homePage = new Contingency_Plan.HomePage();
			this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
			this.materialTabControl1.SuspendLayout();
			this.homePageTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// materialTabControl1
			// 
			this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialTabControl1.Controls.Add(this.homePageTab);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.Location = new System.Drawing.Point(12, 107);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new System.Drawing.Size(513, 305);
			this.materialTabControl1.TabIndex = 0;
			this.materialTabControl1.SelectedIndexChanged += new EventHandler(materialTabControl1_SelectedIndexChanged);
			// 
			// homePageTab
			// 
			this.homePageTab.Controls.Add(this.homePage);
			this.homePageTab.Location = new System.Drawing.Point(4, 22);
			this.homePageTab.Name = "homePageTab";
			this.homePageTab.Padding = new System.Windows.Forms.Padding(3);
			this.homePageTab.Size = new System.Drawing.Size(505, 279);
			this.homePageTab.TabIndex = 0;
			this.homePageTab.Text = "Home Page";
			this.homePageTab.UseVisualStyleBackColor = true;
			// 
			// homePage
			// 
			this.homePage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.homePage.Location = new System.Drawing.Point(3, 3);
			this.homePage.Name = "homePage";
			this.homePage.Size = new System.Drawing.Size(499, 273);
			this.homePage.TabIndex = 0;
			this.homePage.onUserOpenClicked += new Contingency_Plan.HomePage.clickEventHandeler(this.onOpen);
			this.homePage.onUserQuitClicked += new Contingency_Plan.HomePage.clickEventHandeler(this.onQuit);
			this.homePage.onUserHelpClicked += new Contingency_Plan.HomePage.clickEventHandeler(this.onHelp);
			this.homePage.onUserAboutClicked += new Contingency_Plan.HomePage.clickEventHandeler(this.onAbout);
			this.homePage.onUserFiniteAutomataButtonClicked += new Contingency_Plan.HomePage.clickEventHandeler(this.finiteAutomata_click);
			this.homePage.onUserGrammarButtonClicked += new Contingency_Plan.HomePage.clickEventHandeler(this.grammar_click);
			this.homePage.onUserPushDownAutomataButtonClicked += new Contingency_Plan.HomePage.clickEventHandeler(this.pushDownAutomata_click);
			this.homePage.onUserTuringMachineButtonClicked += new Contingency_Plan.HomePage.clickEventHandeler(this.turingMachine_click);
			// 
			// materialTabSelector1
			// 
			this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
			this.materialTabSelector1.Depth = 0;
			this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
			this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabSelector1.Name = "materialTabSelector1";
			this.materialTabSelector1.Size = new System.Drawing.Size(537, 37);
			this.materialTabSelector1.TabIndex = 1;
			this.materialTabSelector1.Text = "materialTabSelector1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 432);
			this.Controls.Add(this.materialTabSelector1);
			this.Controls.Add(this.materialTabControl1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Sizable = false;
			this.Text = "Automator";
			this.materialTabControl1.ResumeLayout(false);
			this.homePageTab.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage homePageTab;
        private HomePage homePage;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}

