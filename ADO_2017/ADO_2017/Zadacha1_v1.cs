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
    public partial class Zadacha1_v1 : Form
    {
        public Zadacha1_v1()
        {
            InitializeComponent();
        }

        private void Zadacha1_v1_Load(object sender, EventArgs e)
        {

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            int p = int.Parse(txtPrice.Text);
            zadacha1TableAdapter.Fill(myBaseDataSet.Zadacha1,p);
        }
    }
}
