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
    public partial class FrmConvertor : Form
    {
        WindConverter c1 = null;
        public FrmConvertor()
        {
            InitializeComponent();
        }

        private void FrmConvertor_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double knots = Convert.ToInt32(txtDistance.Text);
            WindConverter c1 = new WindConverter();
            if (rbtmph.Checked)
            {
                lblDistance.Text = c1.KnotsToMph(knots).ToString();
            }
            if (rbtkph.Checked)
            {
                lblDistance.Text = c1.KnotsToKph(knots).ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    class WindConverter
    {
        private double kn;
        public WindConverter()
        {
            kn = 0;
        }
        public WindConverter(double k)
        {
            kn=k;
        }
        public double KnotsToMph(double kn)
        {
            return kn * 1.15078;
            
        }
        public double KnotsToKph(double kn)
        {
            return kn * 1.852;
        }
    }

}
