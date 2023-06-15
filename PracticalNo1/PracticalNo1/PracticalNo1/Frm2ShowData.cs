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

    public partial class Frm2ShowData : Form
    {
        public Frm2ShowData()
        {
            InitializeComponent();
        }

        private void Frm2ShowData_Load(object sender, EventArgs e)
        {
            lblFName.Text = Frm1ShowData.fname;
            lblMName.Text = Frm1ShowData.mname;
            lblSName.Text = Frm1ShowData.sname;
            lblDOB.Text = Frm1ShowData.dob;
            lblAddress.Text = Frm1ShowData.add;
            lblMNo.Text = Frm1ShowData.mo;
            lblCity.Text = Frm1ShowData.city;
            lblGender.Text = Frm1ShowData.gender;
            lblHobbies.Text = Frm1ShowData.hobbies;
            lblUserName.Text = Frm1ShowData.username;
            lblPassword.Text = Frm1ShowData.password;
            pictureBox1.Image = Frm1ShowData.img;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblFName_Click(object sender, EventArgs e)
        {

        }
    }
}
