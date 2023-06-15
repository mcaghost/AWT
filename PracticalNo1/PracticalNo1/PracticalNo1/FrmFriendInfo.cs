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
    public partial class FrmFriendInfo : Form
    {
        Marks m1 = null;
        public FrmFriendInfo()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmFriendInfo_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int rollNo = Convert.ToInt32(txtRollNo.Text);
                string name = txtName.Text;
                int m = Convert.ToInt32(txtMaths.Text);
                int p = Convert.ToInt32(txtPhys.Text);
                int c = Convert.ToInt32(txtChem.Text);

                m1 = new Marks(rollNo, name, m, p, c);
                MessageBox.Show("Object created successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Caught!" + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                double percent = m1.display();
                if(percent==0)
                {
                    lblResult.Text = "Fail";
                }
                else
                {
                    lblResult.Text = "Pass Total Marks obtained" + m1.totalMarks() + " out of 300";
                    lblPercentage.Text = "Percentage = " + percent;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Caught!" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRollNo.Clear();
            txtName.Clear();
            txtMaths.Clear();
            txtPhys.Clear();
            txtChem.Clear();
            lblResult.Text = "";
            lblPercentage.Text = "";
        }
    }
    public class Student
    {
        protected int rollNo;
        protected string name;

        public Student()
        { }

        public Student(int rollNo, String name)
        {
            this.rollNo = rollNo;
            this.name = name;
        }

        public int getRollNo()
        {
            return rollNo;
        }

        public String getName()
        {
            return name;
        }
    }
    public class Marks: Student
    {
        int mathematics;
        int physics;
        int chemistry;

        public Marks(int sr, String sn, int maths, int phys, int chem) : base(sr, sn)
        {
            mathematics = maths;
            physics = phys;
            chemistry = chem;
        }
        public int totalMarks()
        {
            return (mathematics + physics + chemistry);
        }
        public float display()
        {
            if(mathematics<45||physics<45||chemistry<45)
            {
                return 0;
            }
            else
            {
                float percentage = (mathematics + physics + chemistry) * 100 / 300;
                return percentage;
            }
        }
    }
}
