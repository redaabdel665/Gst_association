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
    public partial class Frmabonnement : Form
    {
        public Frmabonnement()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Gst_associationdb;Integrated Security=True;Connect Timeout=30;");

        private void Fillidclient()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Idclient from Tclient", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Idclient", typeof(string));
            dt.Load(rdr);
            DataRow topitem = dt.NewRow();
            topitem[0] = 0;
            topitem[0] = "--Selectionner--";
            dt.Rows.InsertAt(topitem, 0);
            Cmbidclient.ValueMember = "Idclient";
            Cmbidclient.DataSource = dt;
            Con.Close();


        }

        private void relatedata()
        {
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Gst_associationdb;Integrated Security=True;Connect Timeout=30;");
        Con.Open();
        string a = Cmbidclient.SelectedValue.ToString();

            if (a != "--Selectionner--")
            {
                if (a != null)
                {
                    int b = Convert.ToInt32(a);
                    string query = "select * from Tclient where Idclient = " + b + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Txtnomclient.Text = dr["Nomclient"].ToString();
                        Txtprenomclient.Text = dr["Prenomclient"].ToString();
                    }
                }
            }
        
            Con.Close();
        }

        private void Frmabonnement_Load(object sender, EventArgs e)
        {
            Fillidclient();
            populatedgvabonnement();
            Dgvabonnement.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
        }

        private void Btnajouter_Click(object sender, EventArgs e)
        {
            if (Cmbidclient.SelectedValue.ToString() == "--Selectionner--" || Txtnrcontrat.Text == "" || Txtdateabonnement.Text == "" || Txtmontantpaye.Text == "" || Txtidabonnement.Text == "")
            {
                MessageBox.Show("Informations Abonnement manqantes");
            }
            else
            {

                Con.Open();                          
                int a = Convert.ToInt32(Cmbidclient.SelectedValue);
               
                
                

                string lstrDate = Txtdateabonnement.Text;
                DateTime date2 = Convert.ToDateTime(lstrDate);
                var date3 = date2.Date;
                var D = date3.Day;
                var M = date3.Month;
                var y = date3.Year;
                string monthStr = M.ToString("00");
                string date4 = monthStr.ToString() + "/" + D.ToString() + "/" + y.ToString();


                


                string query = "insert into Tabonnement values('" + Txtidabonnement.Text + "','" + a + "','" + Txtnrcontrat.Text + "','" + Txtmontantpaye.Text + "','" + date4 + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client a été ajouté avex succes");
                Con.Close();
                Fillidclient();
                populatedgvabonnement();

                // mets les champs dans zones vide

                Txtidabonnement.Text = "";
                Cmbidclient.SelectedValue = "--Selectionner--";
                Txtnomclient.Text = "";
                Txtprenomclient.Text = "";
                Txtnrcontrat.Text = "";
                Txtdateabonnement.Value = DateTime.Today;
                Txtmontantpaye.Text = "";

            }
        }

        public void populatedgvabonnement()
        {
            Con.Open();
            string query = "select * from Tabonnement";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Dgvabonnement.DataSource = ds.Tables[0];
            Dgvabonnement.Columns[0].HeaderText = "ID ABONNEMENT";
            Dgvabonnement.Columns[1].HeaderText = "ID CLIENT";
            Dgvabonnement.Columns[2].HeaderText = "CONTRAT N°";
            Dgvabonnement.Columns[4].HeaderText = "DATE ABONNEMENT";
            Dgvabonnement.Columns[5].HeaderText = "FRAIS ABONNEMENT";

            Dgvabonnement.Columns[3].Visible = false;


            Con.Close();
        }

        private void Dgvabonnement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btnsupprimer_Click(object sender, EventArgs e)
        {
            if (Txtidabonnement.Text == "")
            {
                MessageBox.Show("Identifiant Abonnement manqant");
            }
            else
            {
                Con.Open();
                string query = "delete from Tabonnement where Idabonnement = " + Txtidabonnement.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Abonnement supprimé avec succes");
                Con.Close();
                populatedgvabonnement();

                // mets les champs dans zones vide

                Txtidabonnement.Text = "";
                Cmbidclient.SelectedValue = "--Selectionner--";
                Txtnomclient.Text = "";
                Txtprenomclient.Text = "";
                Txtnrcontrat.Text = "";
                Txtdateabonnement.Value = DateTime.Today;
                Txtmontantpaye.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Dgvabonnement.RowCount > 1)
            {
                Txtidabonnement.Text = Dgvabonnement.SelectedRows[0].Cells[0].Value.ToString();
                Cmbidclient.SelectedValue = Dgvabonnement.SelectedRows[0].Cells[1].Value.ToString();
                //Cmbidclient.SelectedItem = Dgvabonnement.SelectedRows[0].Cells[1].Value.ToString();
                Txtnrcontrat.Text = Dgvabonnement.SelectedRows[0].Cells[2].Value.ToString();
                Txtmontantpaye.Text = Dgvabonnement.SelectedRows[0].Cells[3].Value.ToString();
                Txtdateabonnement.Text = Dgvabonnement.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void Txtdateabonnement_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmbidclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            relatedata();
        }

        private void Cmbidclient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            relatedata();
        }

        private void Btnmodifier_Click(object sender, EventArgs e)
        {
            if (Cmbidclient.SelectedValue.ToString() == "--Selectionner--" || Txtnrcontrat.Text == "" || Txtdateabonnement.Text == "" || Txtmontantpaye.Text == "" || Txtidabonnement.Text == "")
            {
                MessageBox.Show("Informations Abonnement manqantes");
            }
            else
            {

                Con.Open();
                int a = Convert.ToInt32(Cmbidclient.SelectedValue);




                string lstrDate = Txtdateabonnement.Text;
                DateTime date2 = Convert.ToDateTime(lstrDate);
                var date3 = date2.Date;
                var D = date3.Day;
                var M = date3.Month;
                var y = date3.Year;
                string monthStr = M.ToString("00");
                string date4 = monthStr.ToString() + "/" + D.ToString() + "/" + y.ToString();





                string query = "update Tabonnement set Idabonnement='" + Txtidabonnement.Text + "',Idclient='" + a + "',Nrcontrat='" + Txtnrcontrat.Text + "',Montantpaye='" + Txtmontantpaye.Text + "',Dateabonnement='" + date4 + "' WHERE Idabonnement = '" + Txtidabonnement.Text + "'; ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client a été modifié avex succes");
                Con.Close();
                Fillidclient();
                populatedgvabonnement();

                // mets les champs dans zones vide

                Txtidabonnement.Text = "";
                Cmbidclient.SelectedValue = "--Selectionner--";
                Txtnomclient.Text = "";
                Txtprenomclient.Text = "";
                Txtnrcontrat.Text = "";
                Txtdateabonnement.Value = DateTime.Today;
                Txtmontantpaye.Text = "";

            }
        }
    }
}
