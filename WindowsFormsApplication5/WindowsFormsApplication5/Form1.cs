using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.Models;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        GruberContext ctx = new GruberContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Customers.ToList();//.Where(c=>c.Orders.Count(o=>o.Amt>1000) > 1).ToList();
            ctx.ChangeTracker.DetectChanges(); 
             
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            //dataGridView1.CurrentRow.Cells["Cnum"]
            if (dataGridView1.CurrentRow != null)
            {
                int cnum = Convert.ToInt32((sender as DataGridView).CurrentRow.Cells["Cnum"].Value);
                dataGridView2.DataSource = ctx.Orders.Where(o => o.Cnum == cnum).ToList();

            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.Columns[e.ColumnIndex].Name;
            string value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var custs = (dataGridView1.DataSource as List<Customer>);
            foreach(Customer cu in custs)
            {
                Customer cv = ctx.Customers.First(c => c.Cnum == cu.Cnum);
                cv.Cname  = cu.Cname;
                cv.City   = cu.City;
                cv.Rating = cu.Rating;
            }
           // ctx.Customers.Add(new Customer() { });
            ctx.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cnum = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Cnum"].Value);
            ctx.Customers.Remove(ctx.Customers.Single(c => c.Cnum == cnum));
            ctx.SaveChanges();
            MessageBox.Show($"Deleted {cnum}");


        }
    }
}
