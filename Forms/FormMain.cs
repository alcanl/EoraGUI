using EoraGuiDemo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace EoraGuiDemo
{
    public partial class MainForm : Form
    {
        public bool isFullScreen = false;
        private FormPatient PatientForm { get;}
        public MainForm()
        {
            InitializeComponent();
            PatientForm = new FormPatient();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void MenuStripMainFile_MouseLeave(Object sender, EventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseLeave(this.fileToolStripMenuItem);
        }
        private void MenuStripMainFile_MouseMove(Object sender, EventArgs e)
        {
            CommonEvents.ToolStripMenu_MouseMove(this.fileToolStripMenuItem);
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
        private void LanguaeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (LanguaeComboBox.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break; 
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-Tr");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (isFullScreen)
            {
                CommonEvents.ButtonMaximize_Click(PatientForm, PatientForm.buttonMaximize, ref PatientForm.isFullScreen);               
            }

            PatientForm.Show();
        }
    }
}
