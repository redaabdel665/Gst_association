using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gst_association
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmclient frmclient = new Frmclient();
            frmclient.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmabonnement frmabonnement = new Frmabonnement();
            frmabonnement.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnbareme_Click(object sender, EventArgs e)
        {
            Frmbareme frmbareme = new Frmbareme();
            frmbareme.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frmconsommation frmconsommation = new Frmconsommation();
            frmconsommation.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmfacture frmfacture = new Frmfacture();
            frmfacture.ShowDialog();
        }
    }
}
