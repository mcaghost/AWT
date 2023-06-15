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
    public partial class String_Manupulation : Form
    {
        public String_Manupulation()
        {
            InitializeComponent();
        }
        private void String_Manupulation_Load(object sender, EventArgs e)
        {
            lblOutput.Text = " ";
        }
        private void btnLength_Click(object sender, EventArgs e)
        { 
            int l = txtFirst.Text.Length;
            lblOutput.Text = l.ToString();
        }
        private void btnLower_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtFirst.Text.ToLower();
        }
        private void btnUpper_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtFirst.Text.ToUpper();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string count = txtFirst.Text.Trim();
            string[] words = count.Split();
            int l = words.Length;
            MessageBox.Show("Number of words: " + l);
        }
        private void btnJoinString_Click(object sender, EventArgs e)
        {
            string msg = "Hii";
            lblOutput.Text = msg + " " + txtFirst.Text + " " + txtSecond.Text;
        }
    }
}
