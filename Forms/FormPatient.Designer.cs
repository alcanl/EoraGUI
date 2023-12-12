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
            Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
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
            this.labelUser = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelPatient = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelSession = new System.Windows.Forms.Label();
            this.sideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenuButton = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.buttonPatient = new System.Windows.Forms.Button();
            this.panelFirstFit = new System.Windows.Forms.Panel();
            this.buttonFirstFit = new System.Windows.Forms.Button();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.panelFitting = new System.Windows.Forms.Panel();
            this.buttonFitting = new System.Windows.Forms.Button();
            this.panelFinalization = new System.Windows.Forms.Panel();
            this.buttonFinalization = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2PanelTabs = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ButtonREUG = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonRECD = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAudiogram = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonPatient = new Guna.UI2.WinForms.Guna2Button();
            this.panelShadowHolder = new System.Windows.Forms.Panel();
            menuStripMain = new System.Windows.Forms.MenuStrip();
            guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            menuStripMain.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.flowLayoutPanelScreenConf.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.sideBarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenuButton.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelPatient.SuspendLayout();
            this.panelFirstFit.SuspendLayout();
            this.panelConfiguration.SuspendLayout();
            this.panelFitting.SuspendLayout();
            this.panelFinalization.SuspendLayout();
            this.guna2PanelTabs.SuspendLayout();
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
            // guna2DragControl2
            // 
            guna2DragControl2.DockForm = true;
            guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl2.TargetControl = menuStripMain;
            guna2DragControl2.UseTransparentDrag = true;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.tableLayoutPanelTop, "tableLayoutPanelTop");
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelScreenConf, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(menuStripMain, 0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            // 
            // flowLayoutPanelScreenConf
            // 
            this.flowLayoutPanelScreenConf.Controls.Add(this.buttonExit);
            this.flowLayoutPanelScreenConf.Controls.Add(this.buttonMaximize);
            this.flowLayoutPanelScreenConf.Controls.Add(this.buttonMinimize);
            resources.ApplyResources(this.flowLayoutPanelScreenConf, "flowLayoutPanelScreenConf");
            this.flowLayoutPanelScreenConf.Name = "flowLayoutPanelScreenConf";
            this.flowLayoutPanelScreenConf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanelScreenConf_MouseDoubleClick);
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
            this.panel11.Controls.Add(this.labelUser);
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // labelUser
            // 
            resources.ApplyResources(this.labelUser, "labelUser");
            this.labelUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUser.Name = "labelUser";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.labelPatient);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // labelPatient
            // 
            resources.ApplyResources(this.labelPatient, "labelPatient");
            this.labelPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPatient.Name = "labelPatient";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.labelUpdate);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // labelUpdate
            // 
            resources.ApplyResources(this.labelUpdate, "labelUpdate");
            this.labelUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUpdate.Name = "labelUpdate";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.labelSession);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // labelSession
            // 
            resources.ApplyResources(this.labelSession, "labelSession");
            this.labelSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSession.Name = "labelSession";
            // 
            // sideBarContainer
            // 
            this.sideBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sideBarContainer.Controls.Add(this.panel1);
            this.sideBarContainer.Controls.Add(this.panelHome);
            this.sideBarContainer.Controls.Add(this.panelPatient);
            this.sideBarContainer.Controls.Add(this.panelFirstFit);
            this.sideBarContainer.Controls.Add(this.panelConfiguration);
            this.sideBarContainer.Controls.Add(this.panelFitting);
            this.sideBarContainer.Controls.Add(this.panelFinalization);
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
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonMenu, "buttonMenu");
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.menuButton_Click);
            this.buttonMenu.MouseLeave += new System.EventHandler(this.panelMenuButton_MouseLeave);
            this.buttonMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenuButton_MouseMove);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.buttonHome);
            resources.ApplyResources(this.panelHome, "panelHome");
            this.panelHome.Name = "panelHome";
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonHome, "buttonHome");
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // panelPatient
            // 
            this.panelPatient.Controls.Add(this.buttonPatient);
            resources.ApplyResources(this.panelPatient, "panelPatient");
            this.panelPatient.Name = "panelPatient";
            // 
            // buttonPatient
            // 
            this.buttonPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonPatient, "buttonPatient");
            this.buttonPatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.UseVisualStyleBackColor = true;
            // 
            // panelFirstFit
            // 
            this.panelFirstFit.Controls.Add(this.buttonFirstFit);
            resources.ApplyResources(this.panelFirstFit, "panelFirstFit");
            this.panelFirstFit.Name = "panelFirstFit";
            // 
            // buttonFirstFit
            // 
            this.buttonFirstFit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonFirstFit, "buttonFirstFit");
            this.buttonFirstFit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFirstFit.Name = "buttonFirstFit";
            this.buttonFirstFit.UseVisualStyleBackColor = true;
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.Controls.Add(this.buttonConfiguration);
            resources.ApplyResources(this.panelConfiguration, "panelConfiguration");
            this.panelConfiguration.Name = "panelConfiguration";
            // 
            // buttonConfiguration
            // 
            this.buttonConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonConfiguration, "buttonConfiguration");
            this.buttonConfiguration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfiguration.Name = "buttonConfiguration";
            this.buttonConfiguration.UseVisualStyleBackColor = true;
            // 
            // panelFitting
            // 
            this.panelFitting.Controls.Add(this.buttonFitting);
            resources.ApplyResources(this.panelFitting, "panelFitting");
            this.panelFitting.Name = "panelFitting";
            // 
            // buttonFitting
            // 
            this.buttonFitting.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonFitting, "buttonFitting");
            this.buttonFitting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFitting.Name = "buttonFitting";
            this.buttonFitting.UseVisualStyleBackColor = true;
            // 
            // panelFinalization
            // 
            this.panelFinalization.Controls.Add(this.buttonFinalization);
            resources.ApplyResources(this.panelFinalization, "panelFinalization");
            this.panelFinalization.Name = "panelFinalization";
            // 
            // buttonFinalization
            // 
            this.buttonFinalization.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonFinalization, "buttonFinalization");
            this.buttonFinalization.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFinalization.Name = "buttonFinalization";
            this.buttonFinalization.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 5;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // guna2PanelTabs
            // 
            this.guna2PanelTabs.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelTabs.Controls.Add(this.guna2ButtonREUG);
            this.guna2PanelTabs.Controls.Add(this.guna2ButtonRECD);
            this.guna2PanelTabs.Controls.Add(this.guna2ButtonAudiogram);
            this.guna2PanelTabs.Controls.Add(this.guna2ButtonPatient);
            resources.ApplyResources(this.guna2PanelTabs, "guna2PanelTabs");
            this.guna2PanelTabs.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PanelTabs.Name = "guna2PanelTabs";
            // 
            // guna2ButtonREUG
            // 
            resources.ApplyResources(this.guna2ButtonREUG, "guna2ButtonREUG");
            this.guna2ButtonREUG.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonREUG.BorderRadius = 5;
            this.guna2ButtonREUG.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonREUG.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2ButtonREUG.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2ButtonREUG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonREUG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonREUG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonREUG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonREUG.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonREUG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2ButtonREUG.Name = "guna2ButtonREUG";
            this.guna2ButtonREUG.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2ButtonREUG.UseTransparentBackground = true;
            // 
            // guna2ButtonRECD
            // 
            resources.ApplyResources(this.guna2ButtonRECD, "guna2ButtonRECD");
            this.guna2ButtonRECD.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonRECD.BorderRadius = 5;
            this.guna2ButtonRECD.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonRECD.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2ButtonRECD.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2ButtonRECD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonRECD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonRECD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonRECD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonRECD.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonRECD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2ButtonRECD.Name = "guna2ButtonRECD";
            this.guna2ButtonRECD.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2ButtonRECD.UseTransparentBackground = true;
            // 
            // guna2ButtonAudiogram
            // 
            resources.ApplyResources(this.guna2ButtonAudiogram, "guna2ButtonAudiogram");
            this.guna2ButtonAudiogram.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonAudiogram.BorderRadius = 5;
            this.guna2ButtonAudiogram.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonAudiogram.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2ButtonAudiogram.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2ButtonAudiogram.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAudiogram.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAudiogram.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAudiogram.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAudiogram.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonAudiogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2ButtonAudiogram.Name = "guna2ButtonAudiogram";
            this.guna2ButtonAudiogram.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2ButtonAudiogram.UseTransparentBackground = true;
            // 
            // guna2ButtonPatient
            // 
            resources.ApplyResources(this.guna2ButtonPatient, "guna2ButtonPatient");
            this.guna2ButtonPatient.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonPatient.BorderRadius = 5;
            this.guna2ButtonPatient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButtonPatient.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2ButtonPatient.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2ButtonPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonPatient.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2ButtonPatient.Name = "guna2ButtonPatient";
            this.guna2ButtonPatient.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2ButtonPatient.UseTransparentBackground = true;
            this.guna2ButtonPatient.Click += new System.EventHandler(this.guna2ButtonPatient_Click);
            // 
            // panelShadowHolder
            // 
            resources.ApplyResources(this.panelShadowHolder, "panelShadowHolder");
            this.panelShadowHolder.Name = "panelShadowHolder";
            // 
            // FormPatient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelShadowHolder);
            this.Controls.Add(this.guna2PanelTabs);
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
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.sideBarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenuButton.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelPatient.ResumeLayout(false);
            this.panelFirstFit.ResumeLayout(false);
            this.panelConfiguration.ResumeLayout(false);
            this.panelFitting.ResumeLayout(false);
            this.panelFinalization.ResumeLayout(false);
            this.guna2PanelTabs.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panelMenuButton;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Button buttonPatient;
        private System.Windows.Forms.Panel panelFirstFit;
        private System.Windows.Forms.Button buttonFirstFit;
        private System.Windows.Forms.Panel panelConfiguration;
        private System.Windows.Forms.Button buttonConfiguration;
        private System.Windows.Forms.Panel panelFitting;
        private System.Windows.Forms.Button buttonFitting;
        private System.Windows.Forms.Panel panelFinalization;
        private System.Windows.Forms.Button buttonFinalization;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTabs;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonPatient;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonREUG;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonRECD;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAudiogram;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel panelShadowHolder;
    }
}