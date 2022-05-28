using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gst_association
{
    public partial class Frmbareme : Form
    {
        public Frmbareme()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Gst_associationdb;Integrated Security=True;Connect Timeout=30;");
        private void Frmbareme_Load(object sender, EventArgs e)
        {
            populatedgvbareme();
        }

        private void Dgvbareme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void populatedgvbareme()
        {
            Con.Open();
            string query = "select * from Tbareme";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Dgvbareme.DataSource = ds.Tables[0];
            Dgvbareme.Columns[1].Visible = false;
            Dgvbareme.Columns[2].Visible = false;
            Dgvbareme.Columns[5].Visible = false;

            Dgvbareme.Columns[0].HeaderText = "ID BAREME";
            Dgvbareme.Columns[3].HeaderText = "QUANTITE MIN";
            Dgvbareme.Columns[4].HeaderText = "QUANTITE MAX";
            Dgvbareme.Columns[6].HeaderText = "PRIX DE BAREME";


            Con.Close();
        }

        private void Btnajouter_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into Tbareme values('" + Txtidbareme.Text + "','" + Txtbarememin.Text + "','" + Txtbarememax.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Barème a été ajouté avec succes");
            Con.Close();
            populatedgvbareme();
        }

        private void Btnmodifier_Click(object sender, EventArgs e)
        {

        }
    }
}
