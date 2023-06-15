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
    public partial class FrmLeapYear : Form
    {
        LeapYear l1 = null;
        public FrmLeapYear()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(txtLeap.Text);
            LeapYear l1 = new LeapYear(year);
            if(l1.isLeapYear())
            {
                lblyear.Text = year+" is leap year";
            }
            else
            {
                lblyear.Text = year+" is not leap year";
            }
            
        }
        private void FrmLeapYear_Load(object sender, EventArgs e)
        {

        }
    }
    public class LeapYear
    {
        private int y;
        
        public LeapYear()
        {
            y = 0;
        }
        public LeapYear(int y)
        {
            this.y = y;
        }
        public bool isLeapYear()
        {
            if ((y % 4 == 0) && (y % 100 != 0 || (y % 400 == 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
