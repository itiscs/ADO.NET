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
    public partial class Zadacha1_v2 : Form
    {
        public Zadacha1_v2()
        {
            InitializeComponent();
        }

        private void Zadacha1_v2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.TOVARY". При необходимости она может быть перемещена или удалена.
            this.tOVARYTableAdapter.Fill(this.myBaseDataSet.TOVARY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myBaseDataSet.RASXOD". При необходимости она может быть перемещена или удалена.
            this.rASXODTableAdapter.Fill(this.myBaseDataSet.RASXOD);

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            myBaseDataSet.Zadacha1.Clear();
            int p = int.Parse(txtPrice.Text);
            foreach(myBaseDataSet.TOVARYRow tRow in myBaseDataSet.TOVARY.Rows)
            {
                if(tRow.ZENA >= p)
                    foreach(myBaseDataSet.RASXODRow rRow in myBaseDataSet.RASXOD.Rows)
                    {
                        if(rRow.KOD_TOVAR == tRow.KOD_TOVAR)
                        {
                            myBaseDataSet.Zadacha1Row zRow = myBaseDataSet.Zadacha1.NewZadacha1Row();
                            zRow.DATA_RASH = rRow.DATA_RASH;
                            zRow.TOVAR = tRow.TOVAR;
                            zRow.STOIM = rRow.STOIM;
                            zRow.ZENA = tRow.ZENA;
                            zRow.ED_IZM = tRow.ED_IZM;
                            zRow.KOLVO = rRow.KOLVO;
                            myBaseDataSet.Zadacha1.Rows.Add(zRow);

                        }
                    }
            }

        }
    }
}
