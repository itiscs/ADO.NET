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

namespace AdoForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Properties.Settings.Default.NorthwindConnectionString;

                SqlCommand cmd = new SqlCommand("Select * from Products", con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);

                dataGridView1.DataSource = dt;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }   
            //while(rdr.Read())
            //{
            //    rdr.GetDecimal(0)
            //}
            

        }


        private void btnFill_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Properties.Settings.Default.NorthwindConnectionString;

                SqlCommand cmd = new SqlCommand("Select * from Products where CategoryID=@Categ", con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Categ";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                param.Value = int.Parse(txtCateg.Text);
                
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);

                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }

        }
    }
}
