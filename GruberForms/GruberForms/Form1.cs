using GruberForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GruberForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GruberDB ctx = new GruberDB();
            dataGridView1.DataSource = ctx.Orders.ToList();
                                        //(from c in ctx.Customers
                                        //where c.Rating > 100
                                        //orderby c.City descending
                                        //select new { c.Cname, c.City, c.Rating, c.Orders.Count }).ToList(); 
        }
    }
}
