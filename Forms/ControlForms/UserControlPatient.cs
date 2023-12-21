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
    public partial class UserControlPatient : UserControl
    {
        public UserControlPatient()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x2000000;
                return handleParams;
            }
        }

        private void patientListDTOBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
