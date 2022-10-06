using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TakimApp.Abstract;

namespace TakimApp.Concrete
{
    public class TakimSahibi : ICalisan
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public string Gender { get; set; }

        public void Work()
        {
            System.Windows.Forms.MessageBox.Show("Kardeş bu takımın sahibi benim bu takımı ben yönetirim.");
        }
    }
}
