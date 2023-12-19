namespace EoraGuiDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fittingDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonNews = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelClient = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelNews = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelTools = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelUpdates = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelSetup = new System.Windows.Forms.Label();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelScreenConf = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.LanguaeComboBox = new System.Windows.Forms.ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            menuStripMain = new System.Windows.Forms.MenuStrip();
            menuStripMain.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.flowLayoutPanelScreenConf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.BackColor = System.Drawing.Color.Black;
            menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            menuStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            menuStripMain.ForeColor = System.Drawing.Color.White;
            menuStripMain.GripMargin = new System.Windows.Forms.Padding(6);
            menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.fittingDeviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            menuStripMain.Location = new System.Drawing.Point(43, 4);
            menuStripMain.Margin = new System.Windows.Forms.Padding(43, 4, 0, 0);
            menuStripMain.MinimumSize = new System.Drawing.Size(386, 20);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            menuStripMain.Size = new System.Drawing.Size(581, 23);
            menuStripMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.fileToolStripMenuItem.Text = "Dosya";
            this.fileToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuStripMainFile_MouseLeave);
            this.fileToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStripMainFile_MouseMove);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.connectToolStripMenuItem.Text = "Bağlan";
            this.connectToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuStripMainConnect_MouseLeave);
            this.connectToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStripMainConnect_MouseMove);
            // 
            // fittingDeviceToolStripMenuItem
            // 
            this.fittingDeviceToolStripMenuItem.Name = "fittingDeviceToolStripMenuItem";
            this.fittingDeviceToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.fittingDeviceToolStripMenuItem.Text = "Cihaz Uyarlama";
            this.fittingDeviceToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuStripMainFitting_MouseLeave);
            this.fittingDeviceToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStripMainFitting_MouseMove);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.helpToolStripMenuItem.Text = "Yardım";
            this.helpToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuStripMainHelp_MouseLeave);
            this.helpToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStripMainHelp_MouseMove);
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelBottom.ColumnCount = 5;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBottom.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanelBottom.Controls.Add(this.panel7, 1, 1);
            this.tableLayoutPanelBottom.Controls.Add(this.panel8, 2, 1);
            this.tableLayoutPanelBottom.Controls.Add(this.panel9, 3, 1);
            this.tableLayoutPanelBottom.Controls.Add(this.panel10, 4, 1);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 621);
            this.tableLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelBottom.MinimumSize = new System.Drawing.Size(915, 162);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 2;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(1236, 162);
            this.tableLayoutPanelBottom.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 109);
            this.panel1.TabIndex = 0;
            // 
            // ButtonUser
            // 
            this.ButtonUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonUser.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUser.HoverState.ImageSize = new System.Drawing.Size(84, 84);
            this.ButtonUser.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUser.Image")));
            this.ButtonUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonUser.ImageRotate = 0F;
            this.ButtonUser.ImageSize = new System.Drawing.Size(74, 74);
            this.ButtonUser.Location = new System.Drawing.Point(65, 15);
            this.ButtonUser.Name = "ButtonUser";
            this.ButtonUser.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonUser.Size = new System.Drawing.Size(112, 75);
            this.ButtonUser.TabIndex = 0;
            this.ButtonUser.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonNews);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 109);
            this.panel2.TabIndex = 1;
            // 
            // ButtonNews
            // 
            this.ButtonNews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonNews.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNews.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNews.HoverState.ImageSize = new System.Drawing.Size(86, 86);
            this.ButtonNews.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNews.Image")));
            this.ButtonNews.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonNews.ImageRotate = 0F;
            this.ButtonNews.ImageSize = new System.Drawing.Size(74, 74);
            this.ButtonNews.Location = new System.Drawing.Point(64, 17);
            this.ButtonNews.Name = "ButtonNews";
            this.ButtonNews.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonNews.Size = new System.Drawing.Size(112, 75);
            this.ButtonNews.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2ImageButton3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(497, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 109);
            this.panel3.TabIndex = 2;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(72, 72);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(57, 57);
            this.guna2ImageButton3.Location = new System.Drawing.Point(64, 17);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Size = new System.Drawing.Size(112, 75);
            this.guna2ImageButton3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.guna2ImageButton4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(744, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 109);
            this.panel4.TabIndex = 3;
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(72, 72);
            this.guna2ImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton4.Image")));
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(59, 59);
            this.guna2ImageButton4.Location = new System.Drawing.Point(64, 17);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Size = new System.Drawing.Size(112, 75);
            this.guna2ImageButton4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.guna2ImageButton5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(991, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 109);
            this.panel5.TabIndex = 4;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(70, 70);
            this.guna2ImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton5.Image")));
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(57, 57);
            this.guna2ImageButton5.Location = new System.Drawing.Point(65, 17);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Size = new System.Drawing.Size(112, 75);
            this.guna2ImageButton5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelClient);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 115);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 45);
            this.panel6.TabIndex = 5;
            // 
            // labelClient
            // 
            this.labelClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelClient.ForeColor = System.Drawing.SystemColors.Control;
            this.labelClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelClient.Location = new System.Drawing.Point(53, 3);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(131, 21);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Kullanıcı & Oturum";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.labelNews);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(250, 115);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 45);
            this.panel7.TabIndex = 6;
            // 
            // labelNews
            // 
            this.labelNews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNews.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNews.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNews.Location = new System.Drawing.Point(83, 3);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(73, 21);
            this.labelNews.TabIndex = 1;
            this.labelNews.Text = "Yenilikler";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.labelTools);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(497, 115);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(241, 45);
            this.panel8.TabIndex = 7;
            // 
            // labelTools
            // 
            this.labelTools.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTools.AutoSize = true;
            this.labelTools.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTools.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTools.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTools.Location = new System.Drawing.Point(88, 3);
            this.labelTools.Name = "labelTools";
            this.labelTools.Size = new System.Drawing.Size(59, 21);
            this.labelTools.TabIndex = 1;
            this.labelTools.Text = "Araçlar";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.labelUpdates);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(744, 115);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(241, 45);
            this.panel9.TabIndex = 8;
            // 
            // labelUpdates
            // 
            this.labelUpdates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUpdates.AutoSize = true;
            this.labelUpdates.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelUpdates.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUpdates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUpdates.Location = new System.Drawing.Point(58, 4);
            this.labelUpdates.Name = "labelUpdates";
            this.labelUpdates.Size = new System.Drawing.Size(132, 21);
            this.labelUpdates.TabIndex = 1;
            this.labelUpdates.Text = "Güncelleştirmeler";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.labelSetup);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(991, 115);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(242, 45);
            this.panel10.TabIndex = 9;
            // 
            // labelSetup
            // 
            this.labelSetup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSetup.AutoSize = true;
            this.labelSetup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSetup.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSetup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSetup.Location = new System.Drawing.Point(89, 4);
            this.labelSetup.Name = "labelSetup";
            this.labelSetup.Size = new System.Drawing.Size(70, 21);
            this.labelSetup.TabIndex = 1;
            this.labelSetup.Text = "Kurulum";
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanelTop.Controls.Add(menuStripMain, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelScreenConf, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1236, 27);
            this.tableLayoutPanelTop.TabIndex = 4;
            // 
            // flowLayoutPanelScreenConf
            // 
            this.flowLayoutPanelScreenConf.Controls.Add(this.buttonExit);
            this.flowLayoutPanelScreenConf.Controls.Add(this.buttonMaximize);
            this.flowLayoutPanelScreenConf.Controls.Add(this.buttonMinimize);
            this.flowLayoutPanelScreenConf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelScreenConf.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelScreenConf.Location = new System.Drawing.Point(624, 0);
            this.flowLayoutPanelScreenConf.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelScreenConf.Name = "flowLayoutPanelScreenConf";
            this.flowLayoutPanelScreenConf.Size = new System.Drawing.Size(612, 27);
            this.flowLayoutPanelScreenConf.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = global::EoraGuiDemo.Properties.Resources.exit_icon;
            this.buttonExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExit.Location = new System.Drawing.Point(568, 2);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 17, 2);
            this.buttonExit.MinimumSize = new System.Drawing.Size(22, 18);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 25);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.buttonExit.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
            this.buttonExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonExit_MouseMove);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = global::EoraGuiDemo.Properties.Resources.setFullScreen;
            this.buttonMaximize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMaximize.Location = new System.Drawing.Point(535, 2);
            this.buttonMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMaximize.MinimumSize = new System.Drawing.Size(22, 18);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(27, 25);
            this.buttonMaximize.TabIndex = 1;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.ButtonMaximize_Click);
            this.buttonMaximize.MouseLeave += new System.EventHandler(this.ButtonMaximize_MouseLeave);
            this.buttonMaximize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMaximize_MouseMove);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Black;
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.Black;
            this.buttonMinimize.Image = global::EoraGuiDemo.Properties.Resources.window_minimize__1_;
            this.buttonMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMinimize.Location = new System.Drawing.Point(502, 2);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinimize.MinimumSize = new System.Drawing.Size(27, 25);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(27, 25);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.ButtonMinimize_MouseLeave);
            this.buttonMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMinimize_MouseMove);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Image = global::EoraGuiDemo.Properties.Resources.facebook_page_cover_820x312;
            this.pictureBoxMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxMain.InitialImage = global::EoraGuiDemo.Properties.Resources.facebook_page_cover_820x312;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1236, 594);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMain.TabIndex = 5;
            this.pictureBoxMain.TabStop = false;
            // 
            // LanguaeComboBox
            // 
            this.LanguaeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguaeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguaeComboBox.FormattingEnabled = true;
            this.LanguaeComboBox.Items.AddRange(new object[] {
            "English(Default)",
            "Türkçe",
            "Deutsch"});
            this.LanguaeComboBox.Location = new System.Drawing.Point(1115, 56);
            this.LanguaeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LanguaeComboBox.Name = "LanguaeComboBox";
            this.LanguaeComboBox.Size = new System.Drawing.Size(104, 20);
            this.LanguaeComboBox.TabIndex = 6;
            this.LanguaeComboBox.Tag = "";
            this.LanguaeComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguaeComboBox_SelectedIndexChanged_1);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = menuStripMain;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1236, 783);
            this.Controls.Add(this.LanguaeComboBox);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1236, 783);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EoraFitting v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.flowLayoutPanelScreenConf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fittingDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelScreenConf;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Label labelTools;
        private System.Windows.Forms.Label labelUpdates;
        private System.Windows.Forms.Label labelSetup;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.ComboBox LanguaeComboBox;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonUser;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonNews;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        public System.Windows.Forms.Button buttonMaximize;
    }
}

