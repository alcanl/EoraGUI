using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoraGuiDemo.Interfaces
{
    public interface IPatient
    {
        string Name { get; set; }
        string LastName { get; set; }
        string Fullname { get;}
        DateTime Birthdate { get; set; }
        string Adress {  get; set; }
        string PhoneNumber { get; set; }
        string Description { get; set; }
        IAudiogramData AudiogramData { get; set; }
        ISessionData SessionData { get; set; }
        int Age();
    }
}
