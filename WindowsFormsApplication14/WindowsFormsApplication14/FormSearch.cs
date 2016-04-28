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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

      

        private void FormSearch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.POKUPATELI". При необходимости она может быть перемещена или удалена.
            this.pOKUPATELITableAdapter.Fill(this.myBaseDataSet.POKUPATELI);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.RASXOD". При необходимости она может быть перемещена или удалена.
            this.rASXODTableAdapter.Fill(this.myBaseDataSet.RASXOD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.TOVARY". При необходимости она может быть перемещена или удалена.
            this.tOVARYTableAdapter.Fill(this.myBaseDataSet.TOVARY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.POKUPATELI". При необходимости она может быть перемещена или удалена.

        }

        private void btnKod_Click(object sender, EventArgs e)
        {
            try
            {
                int index = tOVARYBindingSource.Find("KOD_TOVAR", Convert.ToInt32(txtKod.Text));
                if (index < 0)
                    txtKod.Text = "Не найден";
                else
                    tOVARYBindingSource.Position = index;
            }
            catch
            {
                txtKod.Text = "Не найден";
            }
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            try
            {
                int index = tOVARYBindingSource.Find("TOVAR", txtName.Text);
                if (index < 0)
                    txtName.Text = "Не найден";
                else
                    tOVARYBindingSource.Position = index;
            }
            catch
            {
                txtName.Text = "Не найден";
            }

        }

        private void btnEdizm_Click(object sender, EventArgs e)
        {
            try
            {
                int index = tOVARYBindingSource.Find("ED_IZM", txtEdizm.Text);
                if (index < 0)
                {
                    tOVARYBindingSource.Position = -1;
                    txtEdizm.Text = "Не найден";                }
                else
                    tOVARYBindingSource.Position = index;
            }
            catch
            {
                txtEdizm.Text = "Не найден";
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tOVARYBindingSource.EndEdit();
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
