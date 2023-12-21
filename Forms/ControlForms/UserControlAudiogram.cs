using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Guna.Charts.WinForms;
using Brush = System.Windows.Media.Brush;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;
using Label = System.Windows.Forms.Label;

namespace EoraGuiDemo.Forms.ControlForms
{
    public partial class UserControlAudiogram : UserControl
    {
        private AudiogramData.AudiogramData _audiogram;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x2000000;
                return handleParams;
            }
        } 
        public UserControlAudiogram()
        {
            _audiogram = new AudiogramData.AudiogramData();
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            handleAudiogramDraw();

        }

        private void UserControlAudiogram_Load(object sender, EventArgs e)
        {
            
        }
        public void setAudiogram(AudiogramData.AudiogramData audiogram) 
        {
            _audiogram = audiogram;        
        }
        private void handleAudiogramDraw()
        {
            string[] frequency = { "125", "250", "500", "1000", "2000", "4000", "8000" };
            var pointColorsRed = new List<Color>();
            pointColorsRed.Add(Color.Firebrick);
            var pointColorsBlue = new List<Color>();
            pointColorsBlue.Add(Color.SteelBlue);

            AirConductionRight.PointBorderColors = new ColorCollection(pointColorsRed);
            AirConductionRight.PointFillColors = new ColorCollection(pointColorsRed);
            AirConductionLeft.PointBorderColors = new ColorCollection(pointColorsRed);
            AirConductionLeft.PointFillColors = new ColorCollection(pointColorsRed);
            BoneConductionRight.FillColors = new ColorCollection(pointColorsBlue);
            BoneConductionRight.BorderColors = new ColorCollection(pointColorsBlue);
            
            
            for (int i = 0; i < frequency.Length; i++)
            {
                AirConductionRight.DataPoints.Add(frequency[i], 25);
                AirConductionLeft.DataPoints.Add(frequency[i], 0);
                
            }
            chartLeftEar.Datasets.Add(AirConductionLeft);
            chartRightEar.Datasets.Add(AirConductionRight);
            chartRightEar.Update();
            chartLeftEar.Update();
        }

        private void chartRightEar_MouseClick(object sender, MouseEventArgs e)
        {
            chartRightEar.Datasets.Clear();
            AirConductionRight.DataPoints.Update(1, new LPoint("TEST", 450));
            
            chartRightEar.Invalidate();
            MessageBox.Show("Test", "Test");
        }
    }
}
