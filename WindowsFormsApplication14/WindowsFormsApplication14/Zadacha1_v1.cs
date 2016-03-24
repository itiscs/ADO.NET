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
    public partial class Zadacha1_v1 : Form
    {
        public Zadacha1_v1()
        {
            InitializeComponent();
        }

        private void Zadacha1_v1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.Zadacha1". При необходимости она может быть перемещена или удалена.
            this.zadacha1TableAdapter.Fill(this.myBaseDataSet.Zadacha1, 10);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zadacha1TableAdapter.Fill(this.myBaseDataSet.Zadacha1,
                    int.Parse(kOLVOToolStripTextBox.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
