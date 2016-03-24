using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Zadacha1_v2 : Form
    {
        public Zadacha1_v2()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
                Properties.Settings.Default.myBaseConnectionString);

            con.Open();
            String str = "SELECT TOVAR, DATA_RASH, KOLVO, ZENA, STOIM " +   
            " FROM RASXOD INNER JOIN TOVARY ON RASXOD.KOD_TOVAR = TOVARY.KOD_TOVAR " +
            " WHERE KOLVO > " + txtKol.Text;

            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;

            dataGridView1.Refresh();
        }
    }
}
