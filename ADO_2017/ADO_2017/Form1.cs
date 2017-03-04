using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
