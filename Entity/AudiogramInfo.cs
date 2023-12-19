using EoraGuiDemo.Interfaces;
using EoraGuiDemo.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoraGuiDemo.Entity
{
    public class AudiogramInfo : IAudiogramInfo
    {
        public int _hertz125 { get; set; }
        public int _hertz250 { get; set; }
        public int _hertz500 { get; set; }
        public int _hertz1000 { get; set; }
        public int _hertz2000 { get; set; }
        public int _hertz4000 { get; set; }
        public int _hertz8000 { get; set; }
        public AudiogramType AudiogramType {get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            return (new List<int>()
            {
                _hertz125, _hertz250, _hertz500, _hertz1000, _hertz2000, _hertz4000, _hertz8000

            }).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
