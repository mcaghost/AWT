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
    public partial class Frm1ShowData : Form
    {
        public static string fname;
        public static string mname;
        public static string sname;
        public static string dob;
        public static string add;
        public static string mo;
        public static string city;
        public static string gender;
        public static string hobbies;
        public static string username;
        public static string password;
        public static Image img;
        public Frm1ShowData()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Frm1ShowData_Load(object sender, EventArgs e)
        {
 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fname = txtFName.Text;
            mname = txtMName.Text;
            sname = txtSName.Text;
            dob = dateTimePicker1.Text;
            add = txtAddress.Text;
            mo = txtMno.Text;
            city = txtCity.Text;
            username = txtUserName.Text;
            password = txtPassword.Text;
            hobbies = txtHobbies.Text;
            img= pictureBox1.Image;

            if (rbtMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            Frm2ShowData f2 = new Frm2ShowData();
            f2.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imageLoction = "";
         
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLoction = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imageLoction;
            }
        }
    }
}
