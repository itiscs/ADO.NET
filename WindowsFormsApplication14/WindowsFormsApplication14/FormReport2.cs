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
    public partial class FormReport2 : Form
    {
        public FormReport2()
        {
            InitializeComponent();
        }

        private void FormReport2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.RasxodDoc". При необходимости она может быть перемещена или удалена.
            this.RasxodDocTableAdapter.Fill(this.myBaseDataSet.RasxodDoc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.Zadacha2". При необходимости она может быть перемещена или удалена.
            this.Zadacha2TableAdapter.Fill(this.myBaseDataSet.Zadacha2);

            this.reportViewer1.RefreshReport();
        }
    }
}
