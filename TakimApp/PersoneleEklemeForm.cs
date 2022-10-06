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
    public partial class PersoneleEklemeForm : Form
    {
        public PersoneleEklemeForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rdbFutbolcu.Checked)
            {
                Futbolcu addNewSoccer = new Futbolcu()
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    IdentityNumber = txtTcNo.Text,
                };
                if (rdbKadin.Checked)
                {
                    addNewSoccer.Gender = "Kadin";
                }
                if(rdbErkek.Checked)
                {
                    addNewSoccer.Gender = "Erkek";
                }

                Form1.SoccersBindingList.Add(addNewSoccer);
                Form1.EmployeesBindingList.Add(addNewSoccer);
            }
            if (rdbAsci.Checked)
            {
                Asci addNewChef = new Asci()
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    IdentityNumber = txtTcNo.Text,
                };
                if (rdbKadin.Checked)
                {
                    addNewChef.Gender = "Kadin";
                }
                if (rdbErkek.Checked)
                {
                    addNewChef.Gender = "Erkek";
                }

                Form1.ChefsBindingList.Add(addNewChef);
                Form1.EmployeesBindingList.Add(addNewChef);
            }
            if (rdbIdariPersonel.Checked)
            {
                IdariPersonel addNewOfficer = new IdariPersonel()
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    IdentityNumber = txtTcNo.Text,
                };
                if (rdbKadin.Checked)
                {
                    addNewOfficer.Gender = "Kadin";
                }
                if (rdbErkek.Checked)
                {
                    addNewOfficer.Gender = "Erkek";
                }

                Form1.OfficersBindingList.Add(addNewOfficer);
                Form1.EmployeesBindingList.Add(addNewOfficer);
            }

            this.Hide();
            Form1.nesneTut.Show();
        }
    }
}
