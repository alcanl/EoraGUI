using System.Drawing;
using System.Windows.Forms;

namespace EoraGuiDemo.Common
{
    public class CommonEvents
    {
        public static bool isFullScreen = false;
        public static void ToolStripMenu_MouseLeave(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripMenuItem.ForeColor = Color.White;
        }
        public static void ToolStripMenu_MouseMove(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripMenuItem.ForeColor = Color.Black;
        }
        public static void ButtonExit_Click(Form form)
        {
            form.Close();
        }
        public static void ButtonMaximize_Click(Form form, Button buttonMaximize)
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
    }
}
