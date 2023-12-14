using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EoraGuiDemo.Forms.ControlForms
{
    public partial class UserControlAudiogram : UserControl
    {
        public UserControlAudiogram()
        {
            InitializeComponent();
        }

        private void UserControlAudiogram_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
