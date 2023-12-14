using EoraGuiDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace EoraGuiDemo.Entity
{
    public class Patient : IPatient
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public IAudiogramData AudiogramData { get; set; }
        public ISessionData SessionData { get; set; }
        public string Fullname { get => String.Format("{0} {1}", this.Name, this.LastName); }

        public int Age()
        {
            return DateTime.Now.Year - Birthdate.Year;
        }
    }
}
