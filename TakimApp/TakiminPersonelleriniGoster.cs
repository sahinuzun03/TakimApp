using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakimApp
{
    public partial class TakiminPersonelleriniGoster : Form
    {
        public TakiminPersonelleriniGoster()
        {
            InitializeComponent();
        }

        private void TakiminPersonelleriniGoster_Load(object sender, EventArgs e)
        {
            var takim = Form1.TeamsBindingList[GosterFormu.selectionTeam];

            dgwTakimFutbolculari.DataSource = takim.Soccers;
            dgwTakimAscilari.DataSource = takim.Chefs;
            dgwTakimIdariPersonelleri.DataSource = takim.Officers;

        }
    }
}
