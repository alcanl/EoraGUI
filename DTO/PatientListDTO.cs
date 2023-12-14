using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoraGuiDemo.DTO
{
    public class PatientListDTO
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public PatientListDTO() { }
        
    }
}
