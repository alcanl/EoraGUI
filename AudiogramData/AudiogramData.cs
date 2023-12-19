using EoraGuiDemo.Entity;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EoraGuiDemo.Resources;


namespace EoraGuiDemo.AudiogramData
{
    public class AudiogramData
    {
        private Dictionary<AudiogramType, AudiogramInfo> _hearingLoss;

        public AudiogramData() : this(new Dictionary<AudiogramType, AudiogramInfo>()) { }
      
        public AudiogramData(Dictionary<AudiogramType, AudiogramInfo> hearingLoss)
        {
            _hearingLoss = hearingLoss;
        }
        public void setHearingLoss(AudiogramType audiogramType, AudiogramInfo audiogramInfo)
        { 
            _hearingLoss.Add(audiogramType, audiogramInfo);
        }
        public Dictionary<AudiogramType, AudiogramInfo> getHearingLoss()
        {
            return _hearingLoss;
        }
    }
}
