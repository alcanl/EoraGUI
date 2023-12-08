using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EoraGuiDemo
{
    public partial class MainForm : Form
    {
        private bool isFullScreen = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFirstFit_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfiguration_Click(object sender, EventArgs e)
        {

        }

        private void buttonFitting_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void MenuStripMainFile_MouseLeave(Object sender, EventArgs e)
        {
            this.fileToolStripMenuItem.ForeColor = Color.White;
        }
        private void MenuStripMainFile_MouseMove(Object sender, EventArgs e)
        {

            this.fileToolStripMenuItem.ForeColor = Color.Black;
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            if (!isFullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.buttonMaximize.Image = global::EoraGuiDemo.Properties.Resources.unsetFullScreen;
                isFullScreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.buttonMaximize.Image = global::EoraGuiDemo.Properties.Resources.setFullScreen;
                isFullScreen = false;
            }
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ButtonMinimize_MouseMove(object sender, EventArgs e)
        {
            this.buttonMinimize.BackColor = Color.Gray;
        }
        private void ButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            this.buttonMinimize.BackColor = Color.Black;
        }
        private void ButtonMaximize_MouseMove(object sender, EventArgs e)
        {
            this.buttonMaximize.BackColor = Color.Gray;
        }
        private void ButtonMaximize_MouseLeave(object sender, EventArgs e)
        {
            this.buttonMaximize.BackColor = Color.Black;
        }
        private void ButtonExit_MouseMove(object sender, EventArgs e)
        {
            this.buttonExit.BackColor = Color.Gray;
        }
        private void ButtonExit_MouseLeave(object sender, EventArgs e)
        {
            this.buttonExit.BackColor = Color.Black;
        }
        private void MenuStripMainConnect_MouseLeave(Object sender, EventArgs e)
        {
            this.connectToolStripMenuItem.ForeColor = Color.White;
        }
        private void MenuStripMainConnect_MouseMove(Object sender, EventArgs e)
        {

            this.connectToolStripMenuItem.ForeColor = Color.Black;
        }
        private void MenuStripMainFitting_MouseLeave(Object sender, EventArgs e)
        {
            this.fittingDeviceToolStripMenuItem.ForeColor = Color.White;
        }
        private void MenuStripMainFitting_MouseMove(Object sender, EventArgs e)
        {

            this.fittingDeviceToolStripMenuItem.ForeColor = Color.Black;
        }
        private void MenuStripMainHelp_MouseLeave(Object sender, EventArgs e)
        {
            this.helpToolStripMenuItem.ForeColor = Color.White;
        }
        private void MenuStripMainHelp_MouseMove(Object sender, EventArgs e)
        {
            this.helpToolStripMenuItem.ForeColor = Color.Black;
        }
    }
}
