using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class FormReport1 : Form
    {
        public FormReport1()
        {
            InitializeComponent();
        }

        private void FormReport1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.Zadacha1". При необходимости она может быть перемещена или удалена.
            this.Zadacha1TableAdapter.Fill(this.myBaseDataSet.Zadacha1, 10);

            this.reportViewer1.RefreshReport();
        }
    }
}
