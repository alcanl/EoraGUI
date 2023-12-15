using System;
using System.Drawing;
using System.Windows.Forms;

namespace EoraGuiDemo.Common
{
    public class CommonEvents
    {
        public static void ToolStripMenu_MouseLeave(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripMenuItem.ForeColor = Color.White;
        }
        public static void ToolStripMenu_MouseMove(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripMenuItem.ForeColor = Color.Black;
        }
        public static void ButtonExit_Click()
        {
            var answer = MessageBox.Show("Are you sure to close the application?", "Warning",
                MessageBoxButtons.YesNo);

            if (answer.ToString().ToUpper() == "YES")
                Application.Exit();
                
        }
        public static void ButtonMaximize_Click(Form form, Button buttonMaximize, ref bool isFullScreen)
        {
            if (!isFullScreen)
            {
                form.WindowState = FormWindowState.Maximized;
                buttonMaximize.Image = global::EoraGuiDemo.Properties.Resources.unsetFullScreen;
                isFullScreen = true;
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
                buttonMaximize.Image = global::EoraGuiDemo.Properties.Resources.setFullScreen;
                isFullScreen = false;
            }
        }
        public static void ButtonMinimize_Click(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
        public static void MinMaxMouseMove_Hover(Button button)
        {
            button.BackColor = Color.Gray;
        }
        public static void MinMaxMouseLeave_Hover(Button button)
        {
            button.BackColor = Color.Black;
        }
        public static void SideBarTimer_Tick(ref bool sideBarExpand, FlowLayoutPanel sideBarContainer, Timer sideBarTimer)
        {
            if (sideBarExpand)
            {
                sideBarContainer.Width -= 30;

                if (sideBarContainer.Width == sideBarContainer.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                    sideBarContainer.Width += 25;

                if (sideBarContainer.Width == sideBarContainer.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }
        public static void PanelMenuButton_MouseMove(Button buttonMenu, Panel panelMenu)
        {
            buttonMenu.BackColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            panelMenu.BackColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
        }
        public static void PanelMenuButton_MouseLeave(Button buttonMenu, Panel panelMenu)
        {
            buttonMenu.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            panelMenu.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
        }
        public static void AddControlToPanel(Panel panel, Control control) 
        { 
            panel.Controls.Add(control);
        }
    }
}
