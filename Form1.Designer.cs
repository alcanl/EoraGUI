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
            System.Windows.Forms.MenuStrip menuStripMain;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fittingDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelClient = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelNews = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelScreenConf = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.fileToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStripMainFile_MouseMove);
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
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.tableLayoutPanelBottom, "tableLayoutPanelBottom");
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
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelClient);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // labelClient
            // 
            resources.ApplyResources(this.labelClient, "labelClient");
            this.labelClient.ForeColor = System.Drawing.SystemColors.Control;
            this.labelClient.Name = "labelClient";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.labelNews);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // labelNews
            // 
            resources.ApplyResources(this.labelNews, "labelNews");
            this.labelNews.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNews.Name = "labelNews";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.ForeColor = System.Drawing.SystemColors.Control;
            this.label.Name = "label";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label4);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Name = "label4";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label5);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Name = "label5";
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
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::EoraGuiDemo.Properties.Resources.facebook_page_cover_820x312;
            this.pictureBox1.InitialImage = global::EoraGuiDemo.Properties.Resources.facebook_page_cover_820x312;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

