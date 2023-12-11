namespace EoraGuiDemo
{
    partial class FormPatient
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip menuStripMain;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatient));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fittingDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelScreenConf = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.sideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenuButton = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPatients = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonFirstFit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonFitting = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonFinalization = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            menuStripMain = new System.Windows.Forms.MenuStrip();
            menuStripMain.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.flowLayoutPanelScreenConf.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.sideBarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenuButton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(menuStripMain, "menuStripMain");
            menuStripMain.ForeColor = System.Drawing.Color.White;
            menuStripMain.GripMargin = new System.Windows.Forms.Padding(6);
            menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.fittingDeviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            menuStripMain.Name = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuStripMainFile_MouseLeave);
            this.fileToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fileToolStripMenuItem_MouseMove);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            resources.ApplyResources(this.connectToolStripMenuItem, "connectToolStripMenuItem");
            this.connectToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuStripMainConnect_MouseLeave);
            this.connectToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStripMainConnect_MouseMove);
            // 
            // fittingDeviceToolStripMenuItem
            // 
            this.fittingDeviceToolStripMenuItem.Name = "fittingDeviceToolStripMenuItem";
            resources.ApplyResources(this.fittingDeviceToolStripMenuItem, "fittingDeviceToolStripMenuItem");
            this.fittingDeviceToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuStripMainFitting_MouseLeave);
            this.fittingDeviceToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStripMainFitting_MouseMove);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuStripMainHelp_MouseLeave);
            this.helpToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStripMainHelp_MouseMove);
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.tableLayoutPanelTop, "tableLayoutPanelTop");
            this.tableLayoutPanelTop.Controls.Add(menuStripMain, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelScreenConf, 1, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            // 
            // flowLayoutPanelScreenConf
            // 
            this.flowLayoutPanelScreenConf.Controls.Add(this.buttonExit);
            this.flowLayoutPanelScreenConf.Controls.Add(this.buttonMaximize);
            this.flowLayoutPanelScreenConf.Controls.Add(this.buttonMinimize);
            resources.ApplyResources(this.flowLayoutPanelScreenConf, "flowLayoutPanelScreenConf");
            this.flowLayoutPanelScreenConf.Name = "flowLayoutPanelScreenConf";
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Image = global::EoraGuiDemo.Properties.Resources.exit_icon;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.buttonExit.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
            this.buttonExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonExit_MouseMove);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonMaximize, "buttonMaximize");
            this.buttonMaximize.Image = global::EoraGuiDemo.Properties.Resources.setFullScreen;
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.ButtonMaximize_Click);
            this.buttonMaximize.MouseLeave += new System.EventHandler(this.ButtonMaximize_MouseLeave);
            this.buttonMaximize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMaximize_MouseMove);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Black;
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonMinimize, "buttonMinimize");
            this.buttonMinimize.ForeColor = System.Drawing.Color.Black;
            this.buttonMinimize.Image = global::EoraGuiDemo.Properties.Resources.window_minimize__1_;
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.ButtonMinimize_MouseLeave);
            this.buttonMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMinimize_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.panel11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // panel11
            // 
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // panel10
            // 
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // panel9
            // 
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // panel8
            // 
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // sideBarContainer
            // 
            this.sideBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sideBarContainer.Controls.Add(this.panel1);
            this.sideBarContainer.Controls.Add(this.panel2);
            this.sideBarContainer.Controls.Add(this.panel3);
            this.sideBarContainer.Controls.Add(this.panel4);
            this.sideBarContainer.Controls.Add(this.panel5);
            this.sideBarContainer.Controls.Add(this.panel6);
            this.sideBarContainer.Controls.Add(this.panel7);
            resources.ApplyResources(this.sideBarContainer, "sideBarContainer");
            this.sideBarContainer.Name = "sideBarContainer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMenuButton);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panelMenuButton
            // 
            this.panelMenuButton.Controls.Add(this.buttonMenu);
            resources.ApplyResources(this.panelMenuButton, "panelMenuButton");
            this.panelMenuButton.Name = "panelMenuButton";
            this.panelMenuButton.MouseLeave += new System.EventHandler(this.panelMenuButton_MouseLeave);
            this.panelMenuButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenuButton_MouseMove);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.buttonMenu, "buttonMenu");
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonHome);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // buttonHome
            // 
            resources.ApplyResources(this.buttonHome, "buttonHome");
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonPatients);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // buttonPatients
            // 
            resources.ApplyResources(this.buttonPatients, "buttonPatients");
            this.buttonPatients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonConfiguration);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // buttonConfiguration
            // 
            resources.ApplyResources(this.buttonConfiguration, "buttonConfiguration");
            this.buttonConfiguration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfiguration.Name = "buttonConfiguration";
            this.buttonConfiguration.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonFirstFit);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // buttonFirstFit
            // 
            resources.ApplyResources(this.buttonFirstFit, "buttonFirstFit");
            this.buttonFirstFit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFirstFit.Name = "buttonFirstFit";
            this.buttonFirstFit.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonFitting);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // buttonFitting
            // 
            resources.ApplyResources(this.buttonFitting, "buttonFitting");
            this.buttonFitting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFitting.Name = "buttonFitting";
            this.buttonFitting.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonFinalization);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // buttonFinalization
            // 
            resources.ApplyResources(this.buttonFinalization, "buttonFinalization");
            this.buttonFinalization.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFinalization.Name = "buttonFinalization";
            this.buttonFinalization.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // FormPatient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sideBarContainer);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = menuStripMain;
            this.Name = "FormPatient";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.flowLayoutPanelScreenConf.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.sideBarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenuButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fittingDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelScreenConf;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel sideBarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPatients;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonConfiguration;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonFirstFit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonFitting;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonFinalization;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panelMenuButton;
    }
}