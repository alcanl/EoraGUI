﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using EoraGuiDemo.Common;
using EoraGuiDemo.Forms.ControlForms;

namespace EoraGuiDemo
{
    public partial class FormPatient : Form
    {
        private bool sideBarExpand = false;
        public bool isFullScreen = false;
        private readonly Control userControlPatient;
        private readonly Control userControlAudiogram;
        
        public FormPatient()
        {
            InitializeComponent();
            userControlPatient = new UserControlPatient();
            userControlAudiogram = new UserControlAudiogram();
            this.guna2ButtonPatient.PerformClick();
            
        }
        private void MenuStripMainFile_MouseLeave(Object sender, EventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseLeave(this.fileToolStripMenuItem);
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            CommonEvents.ButtonExit_Click();
        }
        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            CommonEvents.ButtonMaximize_Click(this, this.buttonMaximize, ref isFullScreen);
            
        }
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            CommonEvents.ButtonMinimize_Click(this);
        }
        private void ButtonMinimize_MouseMove(object sender, EventArgs e)
        {
            CommonEvents.MinMaxMouseMove_Hover(this.buttonMinimize);
        }
        private void ButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            CommonEvents.MinMaxMouseLeave_Hover(this.buttonMinimize);
        }
        private void ButtonMaximize_MouseMove(object sender, EventArgs e)
        {
            CommonEvents.MinMaxMouseMove_Hover(this.buttonMaximize);
        }
        private void ButtonMaximize_MouseLeave(object sender, EventArgs e)
        {
            CommonEvents.MinMaxMouseLeave_Hover(this.buttonMaximize);
        }
        private void ButtonExit_MouseMove(object sender, EventArgs e)
        {
            CommonEvents.MinMaxMouseMove_Hover(this.buttonExit);
        }
        private void ButtonExit_MouseLeave(object sender, EventArgs e)
        {
            CommonEvents.MinMaxMouseLeave_Hover(this.buttonExit);
        }
        private void MenuStripMainConnect_MouseLeave(Object sender, EventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseLeave(this.connectToolStripMenuItem);
        }
        private void MenuStripMainConnect_MouseMove(Object sender, EventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseMove(this.connectToolStripMenuItem);
        }
        private void MenuStripMainFitting_MouseLeave(Object sender, EventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseLeave(this.fittingDeviceToolStripMenuItem);
        }
        private void MenuStripMainFitting_MouseMove(Object sender, EventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseMove(this.fittingDeviceToolStripMenuItem);
        }
        private void MenuStripMainHelp_MouseLeave(Object sender, EventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseLeave(this.helpToolStripMenuItem);
        }
        private void MenuStripMainHelp_MouseMove(Object sender, EventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseMove(this.helpToolStripMenuItem);
        }
        private void fileToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseMove(this.fileToolStripMenuItem);
        }
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            CommonEvents.SideBarTimer_Tick(ref sideBarExpand, this.sideBarContainer, this.sideBarTimer);
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }
        private void panelMenuButton_MouseMove(object sender, MouseEventArgs e)
        {
            CommonEvents.PanelMenuButton_MouseMove(this.buttonMenu, this.panelMenuButton);
        }

        private void panelMenuButton_MouseLeave(object sender, EventArgs e)
        {
            CommonEvents.PanelMenuButton_MouseLeave(this.buttonMenu, this.panelMenuButton);
        }
        private void flowLayoutPanelScreenConf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CommonEvents.ButtonMaximize_Click(this, this.buttonMaximize, ref isFullScreen);
        }
        private void guna2ButtonPatient_Click(object sender, EventArgs e)
        {
            CommonEvents.AddControlToPanel(this.panelShadowHolder, userControlPatient);
        }
        private void guna2ButtonAudiogram_Click(object sender, EventArgs e)
        {
            CommonEvents.AddControlToPanel(this.panelShadowHolder, userControlAudiogram);
        }
        private void buttonHome_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            System.Windows.Forms.Application.OpenForms[0].Visible = true;   
        }
    }
}
    
