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
    public partial class Frmdemarrage : Form
    {
        private int _ticks;
        public Frmdemarrage()
        {
            InitializeComponent();
            timer1.Start();
        }
                
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            textBox1.Text = _ticks.ToString()+"0"+" % "+"effectué..." ;
            if (_ticks == 10)
            {
                textBox1.Text = "Chargement terminé";
                Frmmenu frmmenu = new Frmmenu(); 
                frmmenu.Show();
                timer1.Stop();
                this.Hide();
            }
               
                
            
        }

        private void Frmdemarrage_Load(object sender, EventArgs e)
        {

        }
    }
}
