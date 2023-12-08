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
            System.Windows.Forms.MenuStrip menuStripMain;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatient));
            System.Windows.Forms.TabControl tabControl1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fittingDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelScreenConf = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            menuStripMain = new System.Windows.Forms.MenuStrip();
            tabControl1 = new System.Windows.Forms.TabControl();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            menuStripMain.SuspendLayout();
            tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.flowLayoutPanelScreenConf.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel12.SuspendLayout();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Controls.Add(this.tabPage3);
            tabControl1.Controls.Add(this.tabPage4);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(tableLayoutPanel3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(this.panel13, 0, 0);
            tableLayoutPanel3.Controls.Add(this.panel14, 1, 0);
            tableLayoutPanel3.Controls.Add(this.panel15, 2, 0);
            tableLayoutPanel3.Controls.Add(this.panel16, 0, 1);
            tableLayoutPanel3.Controls.Add(this.panel17, 1, 1);
            tableLayoutPanel3.Controls.Add(this.panel18, 2, 1);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label1);
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label2);
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label3);
            resources.ApplyResources(this.panel15, "panel15");
            this.panel15.Name = "panel15";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel16
            // 
            resources.ApplyResources(this.panel16, "panel16");
            this.panel16.Name = "panel16";
            // 
            // panel17
            // 
            resources.ApplyResources(this.panel17, "panel17");
            this.panel17.Name = "panel17";
            // 
            // panel18
            // 
            resources.ApplyResources(this.panel18, "panel18");
            this.panel18.Name = "panel18";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel7
            // 
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            // panel12
            // 
            this.panel12.Controls.Add(tabControl1);
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // FormPatient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = menuStripMain;
            this.Name = "FormPatient";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.flowLayoutPanelScreenConf.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}