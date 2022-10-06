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
    public partial class TakimSahibiEklemeForm : Form
    {
        public TakimSahibiEklemeForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TakimSahibi addNewTeamOwner = new TakimSahibi();

            addNewTeamOwner.Name = txtAd.Text;
            addNewTeamOwner.Surname = txtSoyad.Text;
            addNewTeamOwner.IdentityNumber = txtTcNo.Text;
            if (rdbErkek.Checked)
                addNewTeamOwner.Gender = "Erkek";
            if (rdbKadin.Checked)
                addNewTeamOwner.Gender = "Kadin";

            Form1.TeamOwnersBindingList.Add(addNewTeamOwner);

            this.Hide();
            Form1.nesneTut.Show();
        }
    }
}
