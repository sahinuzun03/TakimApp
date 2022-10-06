using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakimApp.Concrete
{
    public class Futbolcu : Calisan
    {
        //Abstract sınıfta abstract bir metot varsa o metot kalıtım alınan sınıf override edilip gövdesinin yazılması gerekiyordu.
        public override void ProfesyonelTopOyna()
        {
            MessageBox.Show("Ben Profesyonel olarak top oynarım");
        }

    }
}
