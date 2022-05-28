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
    public partial class Frmconsommation : Form
    {
        public Frmconsommation()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Gst_associationdb;Integrated Security=True;Connect Timeout=30;");

        private void Txtidclient_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Frmconsommation_Load(object sender, EventArgs e)
        {
            Fillidabonnement();
        }

        private void relatedata()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Gst_associationdb;Integrated Security=True;Connect Timeout=30;");

            Con.Open();

            Txtmaxdateindex.Text = "";
            Txtmaxindex.Text = "";
            Txtidclient.Text = "";
            Txtnomprenom.Text = "";
            Txtsolde.Text = "";
            Txtindexconsommation.Text = "";
            Txtnrfacture.Text = "";
            Txtqteconsommee.Text = "";
            Txtidbareme.Text = "";
            Txtprixbareme.Text = "";

            string a = Cmbidabonnement.SelectedValue.ToString();

            if (a != "--Selectionner--")
            {
                if (a != null)
                {
                    int b = Convert.ToInt32(a);
                    string query = "select Idabonnement, Indexconsommation, Dateindex from Tconsommation where Dateindex = ( select max (Dateindex) from Tconsommation where Idabonnement = " + b + ");";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    string query1 = "select Tabonnement.Idabonnement, Tclient.Idclient, Tclient.Nomclient, Tclient.Prenomclient, Tclient.Solde from Tabonnement INNER JOIN Tclient ON Tabonnement.Idclient = Tclient.Idclient where (Tabonnement.Idabonnement = " + b + ");";
                    SqlCommand cmd1 = new SqlCommand(query1, Con);
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(dt1);

                    foreach (DataRow dr in dt.Rows)
                    {
                        string partiedate = dr["Dateindex"].ToString();

                        Txtmaxdateindex.Text = partiedate.Substring(0, 10).ToString();
                        Txtmaxindex.Text = dr["Indexconsommation"].ToString();
                    }

                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        Txtidclient.Text = dr1["Idclient"].ToString();
                        Txtnomprenom.Text = dr1["Nomclient"].ToString() + dr1["Nomclient"].ToString();
                        Txtsolde.Text = dr1["Solde"].ToString();
                    }

                    Txtfraismaintenance.Text = "5";

                }
            }

            Con.Close();
        }

        private void Fillidabonnement()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Idabonnement from Tabonnement", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Idabonnement", typeof(string));
            dt.Load(rdr);
            DataRow topitem = dt.NewRow();
            topitem[0] = 0;
            topitem[0] = "--Selectionner--";
            dt.Rows.InsertAt(topitem, 0);
            Cmbidabonnement.ValueMember = "Idabonnement";
            Cmbidabonnement.DataSource = dt;
            Con.Close();

        }

        private void Cmbidabonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            relatedata();
        }

        private void Cmbidabonnement_SelectionChangeCommitted(object sender, EventArgs e)
        {

            relatedata();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decimal ic = Convert.ToDecimal(Txtindexconsommation.Text);
            //decimal mi = Convert.ToDecimal(Txtmaxindex.Text);
            //Txtqteconsommee.Text = (ic - mi).ToString();

            int a = Convert.ToInt32(Cmbidabonnement.SelectedValue);

            string lstrDate = Txtdateindex.Text;
            DateTime date2 = Convert.ToDateTime(lstrDate);
            var date3 = date2.Date;
            var D = date3.Day;
            var M = date3.Month;
            var y = date3.Year;
            string monthStr = M.ToString("00");
            string date4 = monthStr.ToString() + "/" + D.ToString() + "/" + y.ToString();

            string lstrDate1 = Txtmaxdateindex.Text;
            DateTime date20 = Convert.ToDateTime(lstrDate1);
            var date30 = date20.Date;
            var D1 = date30.Day;
            var M1 = date30.Month;
            var y1 = date30.Year;
            string monthStr1 = M1.ToString("00");
            string date40 = monthStr1.ToString() + "/" + D1.ToString() + "/" + y1.ToString();


            Con.Open();
            string query = "insert into Tconsommation (Idabonnement, Indexconsommation, Dateindex, Idclient, Dateprecedentindex, Precedentindex) values('" + a + "','" + Txtindexconsommation.Text + "','" + date4 + "','" + Txtidclient.Text + "','" + date40 + "','" + Txtmaxindex.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();

            string query1 = "select Max(Tconsommation.Idconsommation) AS Nrfacture from Tconsommation where (Tconsommation.Idabonnement = " + a + ");";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            foreach (DataRow dr1 in dt1.Rows)
            {
                Txtnrfacture.Text = dr1["Nrfacture"].ToString();
            }

            string query2 = "select Tconsommation.Qteconsommee from Tconsommation where (Tconsommation.Idconsommation = " + Txtnrfacture.Text + ");";
            SqlCommand cmd2 = new SqlCommand(query2, Con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            foreach (DataRow dr2 in dt2.Rows)
            {
                Txtqteconsommee.Text = dr2["Qteconsommee"].ToString();


            }

            string qte = (Txtqteconsommee.Text).ToString();
            string qtestr = qte.Substring(0, qte.IndexOf(","));
            int qted = Convert.ToInt32(qtestr);

            string query3 = "select Tbareme.Idbareme, Tbareme.Prixbareme from Tbareme where (((Tbareme.Baremmind) <= " + qted + ") AND ((Tbareme.Baremmaxd) > " + qted + "));";
            SqlCommand cmd3 = new SqlCommand(query3, Con);
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);


            foreach (DataRow dr3 in dt3.Rows)
            {
                Txtidbareme.Text = dr3["Idbareme"].ToString();
                Txtprixbareme.Text = dr3["Prixbareme"].ToString();
            }

            int intbareme = Convert.ToInt32(Txtidbareme.Text);

            string query4 = "update Tconsommation set Idbareme='" + intbareme + "',Prixbareme='" + Txtprixbareme.Text + "',Fraismaintenance='" + Txtfraismaintenance.Text + "' WHERE Idconsommation = '" + Txtnrfacture.Text + "'; ";
            SqlCommand cmd4 = new SqlCommand(query4, Con);
            cmd4.ExecuteNonQuery();

            Con.Close();


        }



        private void Txtdateindex_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Txtindexconsommation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cmbidabonnement.SelectedValue = "--Selectionner--";
        }
    }
}
