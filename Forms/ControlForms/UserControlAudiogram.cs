using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Media;
using EoraGuiDemo.AudiogramData;
using EoraGuiDemo.Resources;
using Guna.Charts.Interfaces;
using Guna.Charts.WinForms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Brush = System.Windows.Media.Brush;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;
using Label = System.Windows.Forms.Label;

namespace EoraGuiDemo.Forms.ControlForms
{
    public partial class UserControlAudiogram : UserControl
    {
        private AudiogramData.AudiogramData _audiogram;
        /*protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x2000000;
                return handleParams;
            }
        } */
        public UserControlAudiogram()
        {
            _audiogram = new AudiogramData.AudiogramData();
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UserControlAudiogram_Load(object sender, EventArgs e)
        {
            handleAudiogramDraw();
        }
        public void setAudiogram(AudiogramData.AudiogramData audiogram) 
        {
            _audiogram = audiogram;        
        }
        private void handleAudiogramDraw()
        {
            string[] frequency = { "125", "250", "500", "1000", "2000", "4000", "8000" };
            var pointColors = new List<Color>();
            pointColors.Add(Color.Blue);

            AirConductionRight.PointBorderColors = new ColorCollection(pointColors);
            AirConductionRight.PointFillColors = new ColorCollection(pointColors);
            
            
            for (int i = 0; i < frequency.Length; i++)
            {
                AirConductionRight.DataPoints.Add(frequency[i], 0);
            }

            chartRightEar.Datasets.Add(AirConductionRight);
            chartRightEar.Update();
        }

        private void chartRightEar_MouseClick(object sender, MouseEventArgs e)
        {
            chartRightEar.Datasets.Clear();
            AirConductionRight.DataPoints.Update(1, new LPoint("TEST", 450));
            
            chartRightEar.Update();
            MessageBox.Show("Test", "Test");
        }
    }
}
