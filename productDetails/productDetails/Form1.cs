using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new deptconn();
            Department dept = new Department();
            context.Departments.Add(dept);
            dept.ID = Convert.ToInt32(id.Text);
            dept.Name = ename.Text;
            dept.Location = elable.Text;

            context.Departments.Add(dept);
            context.SaveChanges();
        }
    }
}
