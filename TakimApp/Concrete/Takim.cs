using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakimApp.Abstract;

namespace TakimApp.Concrete
{
    public class Takim : ITakim
    {
        //ITakim'dan kalıtım alıyor
        //Constructor metotta listeleri başlatıyorsunuz.
        public string TeamName { get; set; }
        public int NumberOfChamp { get; set; }
        public int NumberOfPlayer { get; set; }
        public DateTime EstablishedDate { get; set; }
        public TakimSahibi TeamOwner { get; set; }
        public List<Futbolcu> Soccers { get; set; }
        public List<Asci> Chefs { get; set; }
        public List<IdariPersonel> Officers { get; set; }
        public int NumberOfEmployees { get; set; }

        public Takim()
        {
            //Banka App içerisinde kullanıcıya IBAN numabarsı yaptık.

            Soccers = new List<Futbolcu>(); //Ben bu listeleri başlatmazsam içerisine veri atma işlemi yapamam.
            Chefs = new List<Asci>();
            Officers = new List<IdariPersonel>();

        }
    }
}
