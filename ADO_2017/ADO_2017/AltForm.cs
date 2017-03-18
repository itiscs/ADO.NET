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
    public partial class AltForm : Form
    {
        public AltForm()
        {
            InitializeComponent();
        }

        private void AltForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.RASXOD". При необходимости она может быть перемещена или удалена.
            this.rASXODTableAdapter.Fill(this.myBaseDataSet.RASXOD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.TOVARY". При необходимости она может быть перемещена или удалена.
            this.tOVARYTableAdapter.Fill(this.myBaseDataSet.TOVARY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.POKUPATELI". При необходимости она может быть перемещена или удалена.
            this.pOKUPATELITableAdapter.Fill(this.myBaseDataSet.POKUPATELI);

            dataGridView1.AutoGenerateColumns = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = pOKUPATELIBindingSource;
            dataGridView1.DataSource = pOKUPATELIBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = tOVARYBindingSource;
            dataGridView1.DataSource = tOVARYBindingSource;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = rASXODBindingSource;
            dataGridView1.DataSource = rASXODBindingSource;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
