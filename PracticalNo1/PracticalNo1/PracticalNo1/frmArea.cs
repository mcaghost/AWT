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
    public partial class frmArea : Form
    {
        Rectangle r1 = null;
        Triangle t1 = null;
        public frmArea()
        {
            InitializeComponent();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            lblAnswer.Text = "";
            lblMessage.Text = "";
            btnRectangle.Enabled = false;
            btnTriangle.Enabled = false;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(txtLength.Text);
            int b = Convert.ToInt32(txtHeight.Text);

            r1 = new Rectangle(l, b);

            lblAnswer.Text = "Area of Rectangle = " + r1.area().ToString();
            lblMessage.Text = r1.show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(txtLength.Text);
            int h = Convert.ToInt32(txtHeight.Text);

            t1 = new Triangle(b, h);

            lblAnswer.Text = "Area of Triangle = " + t1.area().ToString();
            lblMessage.Text = t1.show();
        }

        private void lblMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Enter  length :";
            label3.Text = "Enter breadth :";
            btnRectangle.Enabled = true;
            btnTriangle.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Enter  base :";
            label3.Text = "Enter height :";
            btnRectangle.Enabled = false;
            btnTriangle.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    abstract class Shape
    {
        public virtual double area()
        {
            return 0;
        }
        public abstract string show();
    }
    class Rectangle : Shape
    {
        private  int length;
        private  int width;

        public Rectangle(int l = 0, int b=0)
        {
            length = l;
            width = b;
        }
        public override double area()
        {
            return(width * length);
        }
        public override string show()
        {
            return ("Inside rectangle class !");
        }
    }

    class Triangle : Shape
    {
        private int Base;
        private int height;

        public Triangle(int b=0, int h=0)
        {
            Base = b;
            height = h;
        }

        public override double area()
        {
            return (0.5 * Base * height);
        }
        public override string show()
        {
            return ("Inside Triangle Class");
        }
    }
}
