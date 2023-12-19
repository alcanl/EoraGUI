using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EoraGuiDemo.Resources;

namespace EoraGuiDemo.Interfaces
{
    public interface IAudiogramInfo : IEnumerable<int>
    {
        int _hertz125 {  get; set; }
        int _hertz250 { get; set; }
        int _hertz500 { get; set; }
        int _hertz1000 { get; set; }
        int _hertz2000 { get; set; }
        int _hertz4000 { get; set; }
        int _hertz8000 { get; set; }
        AudiogramType AudiogramType { get; set; }
    }
}
