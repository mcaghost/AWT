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
    public partial class FrmLeapOrNot : Form
    {
        public FrmLeapOrNot()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(txtYear.Text);
            if((year%4==0)&&((year%100!=0)||(year%400==0)))
            {

            }
        }
    }
}
