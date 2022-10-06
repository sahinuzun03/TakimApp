using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TakimApp.Concrete;

namespace TakimApp
{
    public partial class TakimEklemeForm : Form
    {
        public TakimEklemeForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Takim addNewTeam = new Takim();

            addNewTeam.TeamName = txtTakimAdi.Text;
            addNewTeam.NumberOfChamp = (int)nupSampSayisi.Value;
            addNewTeam.NumberOfEmployees = Convert.ToInt32(txtCalisanSayisi.Text);
            addNewTeam.EstablishedDate = dtpKurulusTarihi.Value;

            Form1.TeamsBindingList.Add(addNewTeam);

            this.Hide();
            Form1.nesneTut.Show();
        }
    }
}
