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
    public partial class FrmDigitalClock : Form
    {
        public FrmDigitalClock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text= DateTime.Now.ToString("HH.mm.ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDigitalClock_Load(object sender, EventArgs e)
        {

        }
    }
}
