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
    public partial class GosterFormu : Form
    {
        public GosterFormu()
        {
            InitializeComponent();
        }

        private void GosterFormu_Load(object sender, EventArgs e)
        {
            dgwPersoneller.DataSource = Form1.EmployeesBindingList;

            dgwTakimSahipleri.DataSource = Form1.TeamOwnersBindingList;

            dgwTakimlar.DataSource = Form1.TeamsBindingList;
        }
        public static int selectionTeam;
        int selectionTeamOwner;
        int selectionEmployee;

        private void btnTakimaSahipEkle_Click(object sender, EventArgs e)
        {
            Form1.TeamsBindingList[selectionTeam].TeamOwner = Form1.TeamOwnersBindingList[selectionTeamOwner];
        }


        // Bu aşağıdaki 3 event benim seçilen elemanlarımın indexini bulmak için çalışır.
        private void dgwTakimlar_SelectionChanged(object sender, EventArgs e)
        {
            selectionTeam = dgwTakimlar.CurrentCell.RowIndex;
        }

        private void dgwTakimSahipleri_SelectionChanged(object sender, EventArgs e)
        {
            selectionTeamOwner = dgwTakimSahipleri.CurrentCell.RowIndex;
        }

        private void dgwPersoneller_SelectionChanged(object sender, EventArgs e)
        {
            selectionEmployee = dgwPersoneller.CurrentCell.RowIndex;
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            var gelenKisi = Form1.EmployeesBindingList[selectionEmployee];
            if (gelenKisi is Futbolcu)
            {
                Form1.TeamsBindingList[selectionTeam].Soccers.Add((Futbolcu)gelenKisi);
            }
            if (gelenKisi is Asci)
            {
                Form1.TeamsBindingList[selectionTeam].Chefs.Add((Asci)gelenKisi);
            }
            if (gelenKisi is IdariPersonel)
            {
                Form1.TeamsBindingList[selectionTeam].Officers.Add((IdariPersonel)gelenKisi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TakiminPersonelleriniGoster takiminPersonelleriniGoster = new TakiminPersonelleriniGoster();
            //takiminPersonelleriniGoster.Show();

            dgwPersoneller.DataSource = null;
            dgwTakimlar.DataSource = null;
            dgwTakimSahipleri.DataSource = null;

            var takim = Form1.TeamsBindingList[GosterFormu.selectionTeam];

            dgwPersoneller.DataSource = takim.Soccers;
            dgwTakimlar.DataSource = takim.Chefs;
            dgwTakimSahipleri.DataSource = takim.Officers;
        }
    }
}
