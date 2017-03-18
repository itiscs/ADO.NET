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

namespace ADO_2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.RASXOD". При необходимости она может быть перемещена или удалена.
            this.rASXODTableAdapter.Fill(this.myBaseDataSet.RASXOD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.TOVARY". При необходимости она может быть перемещена или удалена.
            this.tOVARYTableAdapter.Fill(this.myBaseDataSet.TOVARY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.POKUPATELI". При необходимости она может быть перемещена или удалена.
            this.pOKUPATELITableAdapter.Fill(this.myBaseDataSet.POKUPATELI);

        }

       
        private void dgvRasxod_Click(object sender, EventArgs e)
        {
            dgvRasxod.DataSource = rASXODBindingSource;

        }

        private void dgvTovar_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = tOVARYBindingSource;
            dgvRasxod.DataSource = tOVRASHBindingSource;

        }

        private void dgvPokup_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = pOKUPATELIBindingSource;
            dgvRasxod.DataSource = pOKRASHBindingSource;

        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            try
            {
                string tovar = dgvTovar.CurrentRow.
                    Cells["tOVARDataGridViewTextBoxColumn"].Value.ToString();
                
                SqlConnection con = new SqlConnection();
                //con.ConnectionString = Properties.Settings.Default.myBaseConnectionString;
                con.ConnectionString = "Data Source = (localdb)\\v11.0; Initial Catalog = myBase; Integrated Security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Get_Kol_Tov";
                cmd.Parameters.AddWithValue("@Tovar", tovar);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@SumKol";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                con.Open();

                cmd.ExecuteNonQuery();
                int kol = Convert.ToInt32(cmd.Parameters["@SumKol"].Value);
                lblResult.Text = $"Колво - {kol.ToString()}";

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void dgvTovar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltForm f1 = new AltForm();
            f1.ShowDialog();
        }
    }
}
