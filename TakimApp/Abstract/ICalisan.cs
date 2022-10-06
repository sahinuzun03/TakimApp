using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakimApp.Abstract
{
    public interface ICalisan
    {

        string Name { get; set; }
        string Surname { get; set; }
        string IdentityNumber { get; set; }
        string Gender { get; set; }
        void Work();
        
    }
}
