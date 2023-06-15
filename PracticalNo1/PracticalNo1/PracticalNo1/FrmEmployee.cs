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
    public partial class FrmEmployee : Form
    {
        Employee e1 = null;
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            lblID1.Text = " ";
            lblName1.Text = " ";
        }

        private void btnCreateObj_Click(object sender, EventArgs e)
        {
            try
            {

                int eid =Convert.ToInt32( txtEmpID.Text);
                string ename = txtEmpName.Text;
                e1 = new Employee(eid,ename);
                MessageBox.Show("Object Created successfully");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Caught !" + ex.Message);
            }
            finally
            {
                //MessageBox.Show("It,s Finally block!");
            }
        }
      
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblID1.Text = e1.getEmpID().ToString();
            lblName1.Text = e1.getEmpName();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class Employee
    {
        int empID;
        string empName;

        public Employee()
        { }

        public Employee(int e, string n)
        {
            empID = e;
            empName = n;
        }

        ~Employee()
        { }

        public int getEmpID()
        {
            return empID;
        }
        public string getEmpName()
        {
            return empName;
        }
    }
}
