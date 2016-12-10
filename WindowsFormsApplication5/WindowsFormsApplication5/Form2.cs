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
    public partial class Form2 : Form
    {
        GruberContext ctx = new GruberContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  ctx.Orders.GroupBy(o =>new { o.Odate, o.Cnum })
                .Select(g => new { Date = g.Key.Odate, Cnum = g.Key.Cnum, Max = g.Max(o=>o.Amt) })
                .ToList();

        }
    }
}
