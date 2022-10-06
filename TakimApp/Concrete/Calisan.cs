using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TakimApp.Abstract;

namespace TakimApp.Concrete
{
    public abstract class Calisan : ICalisan
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public string Gender { get; set; }

        private int _Age;
        public int Age
        {
            get { return _Age; }
            set
            {
                if (value < 18)
                {
                    _Age = 18;
                }
                else
                    _Age = value;
            }
        }

        private decimal _Wage;
        public decimal Wage
        {
            get { return _Wage; }
            set
            {
                if(value < 5500)
                {
                    _Wage = 5500;
                }
                else
                {
                    _Wage = value;
                }
            }
        }

        //İnterface'de virtual olarak işaretleyemediğim için gelip burada sınıf içerisinde virtual olarak işaretledim
        public virtual void Work()
        {
            MessageBox.Show("Ben Çalışırım");
        }

        public void NefesAl()
        {
            MessageBox.Show("Çalışmak için nefes almam gerekir");
        }

        public abstract void ProfesyonelTopOyna();

    }
}
