using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TakimApp.Abstract;
using TakimApp.Concrete;

namespace TakimApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Generic Yapılar Kavramlar <T> --> Tip farketmeksizin çalışan yapılardır.
        public static Form1 nesneTut;

        //Form1 içerisinde bulunan bütün listeleri binding list olarak ayarladım.
        public static BindingList<Takim> TeamsBindingList = new BindingList<Takim>();
        public static BindingList<Futbolcu> SoccersBindingList = new BindingList<Futbolcu>();
        public static BindingList<TakimSahibi> TeamOwnersBindingList = new BindingList<TakimSahibi>();
        public static BindingList<Asci> ChefsBindingList = new BindingList<Asci>();
        public static BindingList<IdariPersonel> OfficersBindingList = new BindingList<IdariPersonel>();

        public static BindingList<Calisan> EmployeesBindingList = new BindingList<Calisan>();
        private void takimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakimEklemeForm takimEklemeForm = new TakimEklemeForm();
            takimEklemeForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nesneTut = this;
        }

        private void takimSahibiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakimSahibiEklemeForm takimSahibiEklemeForm = new TakimSahibiEklemeForm();
            takimSahibiEklemeForm.Show();
            this.Hide();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersoneleEklemeForm personeleEklemeForm = new PersoneleEklemeForm();
            personeleEklemeForm.Show();
            this.Hide();
        }

        private void takimGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GosterFormu gosterFormu = new GosterFormu();
            gosterFormu.Show();
            this.Hide();
        }

    }
}
