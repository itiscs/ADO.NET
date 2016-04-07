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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tOVARYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tOVARYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.RASXOD". При необходимости она может быть перемещена или удалена.
            this.rASXODTableAdapter.Fill(this.myBaseDataSet.RASXOD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.POKUPATELI". При необходимости она может быть перемещена или удалена.
            this.pOKUPATELITableAdapter.Fill(this.myBaseDataSet.POKUPATELI);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.TOVARY". При необходимости она может быть перемещена или удалена.
            this.tOVARYTableAdapter.Fill(this.myBaseDataSet.TOVARY);

        }

        private void tOVARYDataGridView_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = tOVARYBindingSource;
            dgvRasxod.DataSource = tOVRASHBindingSource;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = pOKUPATELIBindingSource;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int col, row, rowCount;
            col = dgvRasxod.CurrentCell.ColumnIndex;
            row = dgvRasxod.CurrentCell.RowIndex;
            rowCount = dgvRasxod.RowCount;

            if (row < rowCount - 1)
                dgvRasxod.CurrentCell =
                    dgvRasxod[col, row + 1];
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int col, row;
            col = dgvRasxod.CurrentCell.ColumnIndex;
            row = dgvRasxod.CurrentCell.RowIndex;

            if (row > 0)
                dgvRasxod.CurrentCell =
                    dgvRasxod[col, row - 1];
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            int col;
            col = dgvRasxod.CurrentCell.ColumnIndex;
            dgvRasxod.CurrentCell = dgvRasxod[col, 0];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int col;
            col = dgvRasxod.CurrentCell.ColumnIndex;
            dgvRasxod.CurrentCell = dgvRasxod[col, 
                dgvRasxod.RowCount - 1];
        }

        private void dgvRasxod_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvRasxod.CurrentCell != null)
            {
                int row, rowCount;
                row = dgvRasxod.CurrentCell.RowIndex;
                rowCount = dgvRasxod.RowCount;

                if (row == 0)
                    btnPrev.Enabled = false;
                else
                    btnPrev.Enabled = true;

                if (row == rowCount - 1)
                    btnNext.Enabled = false;
                else
                    btnNext.Enabled = true;
            }

        }

        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltForm f = new AltForm();
            f.ShowDialog();
        }

        private void dgvRasxod_Click(object sender, EventArgs e)
        {
            dgvRasxod.DataSource = rASXODBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   --код создания процедуры на sql server
            //  CREATE PROCEDURE[dbo].[Get_Kol_Tov] 
            //	(@Tovar Nvarchar(20), @SumKol Int OUTPUT)
            //  AS BEGIN
            //     SET NOCOUNT ON;
            //	SELECT @SumKol = SUM(r.KOLVO)
            //     FROM TOVARY t INNER JOIN RASXOD r ON t.KOD_TOVAR = r.KOD_TOVAR
            //     WHERE t.TOVAR=@Tovar
            //     GROUP BY t.TOVAR;
            //  END

            SqlConnection con = new SqlConnection(
             "Data Source = (localdb)\\v11.0; Initial Catalog = myBase; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Get_Kol_Tov";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue(
                                  "@Tovar", txtTovar.Text);

            SqlParameter param = new SqlParameter("@SumKol", 
                                            SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            con.Open();
            cmd.ExecuteNonQuery();

            lblResult.Text = cmd.Parameters["@SumKol"].Value.ToString();


            con.Close();
         }

        private void вариант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1_v1 z1 = new Zadacha1_v1();
            z1.ShowDialog();
        }

        private void вариант2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1_v2 z1 = new Zadacha1_v2();
            z1.ShowDialog();
        }

        private void задача1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReport1 fr1 = new FormReport1();
            fr1.ShowDialog();
        }

        private void задача2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport2 fr2 = new FormReport2();
            fr2.ShowDialog();

        }
    }
}
