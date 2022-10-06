using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakimApp.Concrete;

namespace TakimApp.Abstract
{
    public interface ITakim
    {
        string TeamName { get; set; }
        int NumberOfChamp { get; set; }
        int NumberOfPlayer { get; set; }
        DateTime EstablishedDate { get; set; }
        TakimSahibi TeamOwner { get; set; }
        List<Futbolcu> Soccers { get; set; }
        List<Asci> Chefs { get; set; }
        List<IdariPersonel> Officers { get; set; }
        int NumberOfEmployees { get; set; }

        //TakimAdi
        //Şampiyonluk Sayısı
        //OyuncuSayisi
        //Kurulus Tarihi
        //TakimSahibi tipinde TakimSahibi
        //Futbolcular Listesi --> Futbolcular tipinde Liste
        //Ascilar Listesi --> Asçılar tipinde Liste
        //İdariPersonel Listesi --> İdarei Persoenl Tipinde Liste
        //ToplamCalisanSayisi
    }
}
