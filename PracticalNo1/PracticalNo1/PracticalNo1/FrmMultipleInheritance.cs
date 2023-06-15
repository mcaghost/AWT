using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalNo1
{
    public partial class FrmMultipleInheritance : Form
    {
        calculation c1 = null;
        public FrmMultipleInheritance()
        {
            InitializeComponent();
        }

        private void FrmMultipleInheritance_Load(object sender, EventArgs e)
        {
            lblResult.Text = " ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculation c1 = new calculation();
            double n1 = Convert.ToDouble(txtNo1.Text);
            double n2 = Convert.ToDouble(txtNo2.Text);
            lblResult.Text= c1.add(n1,n2).ToString();
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            calculation c1 = new calculation();
            double n1 = Convert.ToDouble(txtNo1.Text);
            double n2 = Convert.ToDouble(txtNo2.Text);
            lblResult.Text = c1.sub(n1, n2).ToString();
        }
    }
    interface addition
    {
         double add(double a, double b);
    }
    interface subtraction
    {
        double sub(double x, double y);
    }
    class calculation:addition,subtraction
    {
        public double result1;
        public double add(double a, double b)
        {
            return result1 = a + b;
        }
        public double result2;
        public double sub(double x, double y)
        {
            return result2 = x - y;
        }
    }
   
}
