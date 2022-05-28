using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Gst_association
{
    public partial class Frmclient : Form
    {
        public Frmclient()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Gst_associationdb;Integrated Security=True;Connect Timeout=30;");

        private void Frmclient_Load(object sender, EventArgs e)
        {
            populatedgvclient();
            Dgvclient.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            //Dgvclient.ColumnHeadersHeight = 24;
        }

        public void populatedgvclient()
        {
            Con.Open();
            string query = "select * from Tclient";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Dgvclient.DataSource = ds.Tables[0] ;

            Dgvclient.Columns[0].HeaderText = "ID CLIENT";
            Dgvclient.Columns[1].HeaderText = "NOM";
            Dgvclient.Columns[2].HeaderText = "PRENOM";
            Dgvclient.Columns[3].HeaderText = "ADRESSE";
            Dgvclient.Columns[4].HeaderText = "TELEPHONE";
            Dgvclient.Columns[5].HeaderText = "OBSERVATION";
            Dgvclient.Columns[6].HeaderText = "SOLDE";

           
            Dgvclient.Columns[7].Visible = false;
            
            Con.Close();
        }

        private void Btnajouter_Click(object sender, EventArgs e)
        {
            if (Txtidclient.Text == "" || Txtnomclient.Text == "" || Txtprenomclient.Text == "" || Txtsolde.Text == "")
            {
                MessageBox.Show("Informations Client manqantes");
            }
            else
            {

                Con.Open();
                //string a = Txtsoldeclient.Text;
                //NumberFormatInfo nfi = new NumberFormatInfo();
                // nfi.NumberDecimalSeparator = ",";

                //decimal Dsolde = Convert.ToDecimal(a, CultureInfo.GetCultureInfo("fr-FR"));

                //decimal decimalVal = System.Convert.ToDecimal(a);

                //NumberStyles style;
                //CultureInfo provider;
                //style = NumberStyles.Any;
                //provider = new CultureInfo("fr")
                //{
                //    NumberFormat =
                //    {
                //         NumberDecimalSeparator = ","
                //    }
                //};
                //decimal Dsoldevalue = decimal.Parse(a, style, provider);

                //var ci = CultureInfo.CurrentCulture.Clone() as CultureInfo;
                // ci.NumberFormat.NumberDecimalSeparator = ",";
                //decimal result = Convert.ToDecimal(a, ci);
                //decimal trctresult = Math.Truncate(result);
                //int trctresult1 = (int)((result - trctresult)*100);
                //decimal Dsoldevalue1 = Dsoldevalue.Replace(",", ".");
                //CultureInfo culture1 = CultureInfo.CurrentCulture;
                //CultureInfo culture2 = Thread.CurrentThread.CurrentCulture;

                string query = "insert into Tclient (Idclient, Nomclient, Prenomclient, Adresseclient, Telephoneclient, Observationsclient, Solde) values('" + Txtidclient.Text + "','" + Txtnomclient.Text + "','" + Txtprenomclient.Text + "','" + Txtadresseclient.Text + "','" + Txttelephoneclient.Text + "','" + Txtobservationsclient.Text + "','" + Txtsolde.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client a été ajouté avex succes");
                Con.Close();
                populatedgvclient();

                // mets les champs dans zones vide
                Txtidclient.Text = "";
                Txtnomclient.Text = "";
                Txtprenomclient.Text = "";
                Txtadresseclient.Text = "";
                Txttelephoneclient.Text = "";
                Txtobservationsclient.Text = "";
                Txtsolde.Text = "";

            }
        }

        private void Btnsupprimer_Click(object sender, EventArgs e)
        {
            if (Txtidclient.Text == "")
            {
                MessageBox.Show("Identifiant Client manqante");
            }
            else
            {
                Con.Open();
                string query = "delete from Tclient where Idclient = " + Txtidclient.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client supprimé avec succes");
                Con.Close();
                populatedgvclient();

                // mets les champs dans zones vide
                Txtidclient.Text = "";
                Txtnomclient.Text = "";
                Txtprenomclient.Text = "";
                Txtadresseclient.Text = "";
                Txttelephoneclient.Text = "";
                Txtobservationsclient.Text = "";
                Txtsolde.Text = "";
            }
        }

        

        private void Btnmodifier_Click(object sender, EventArgs e)
        {
            if (Txtidclient.Text == "")
            {
                MessageBox.Show("Identifiant Client manqante");
            }
            else
            {
                Con.Open();
                //string Dsolde = Txtsoldeclient.Text.ToString();

                //string a = Txtsoldeclient.Text;
                //decimal result = Convert.ToDecimal(a);
               // decimal trctresult = Math.Truncate(result);
                //int trctresult1 = (int)((result - trctresult) * 100);

                string query = "update Tclient set Nomclient='" + Txtnomclient.Text + "',Prenomclient='" + Txtprenomclient.Text + "',Adresseclient='" + Txtadresseclient.Text + "',Telephoneclient='" + Txttelephoneclient.Text + "',Solde='" + Txtsolde.Text + "',Observationsclient='" + Txtobservationsclient.Text + "' WHERE Idclient = '" + Txtidclient.Text + "'; ";        
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client modifié avec succes");
                Con.Close();
                populatedgvclient();

                Txtidclient.Text = "";
                Txtnomclient.Text = "";
                Txtprenomclient.Text = "";
                Txtadresseclient.Text = "";
                Txttelephoneclient.Text = "";
                Txtobservationsclient.Text = "";
                Txtsolde.Text = "";

            }
        }

        private void Txtselrow_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgvclient_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Dgvclient.RowCount > 1)
            { 
            Txtidclient.Text = Dgvclient.SelectedRows[0].Cells[0].Value.ToString();
            Txtnomclient.Text = Dgvclient.SelectedRows[0].Cells[1].Value.ToString();
            Txtprenomclient.Text = Dgvclient.SelectedRows[0].Cells[2].Value.ToString();
            Txtadresseclient.Text = Dgvclient.SelectedRows[0].Cells[3].Value.ToString();
            Txttelephoneclient.Text = Dgvclient.SelectedRows[0].Cells[4].Value.ToString();
            Txtobservationsclient.Text = Dgvclient.SelectedRows[0].Cells[5].Value.ToString();
            Txtsolde.Text = Dgvclient.SelectedRows[0].Cells[6].Value.ToString();
            }
        }
    }
}
