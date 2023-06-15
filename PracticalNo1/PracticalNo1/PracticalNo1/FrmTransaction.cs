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
    public partial class FrmTransaction : Form
    {
        Transaction t1 = null;
        public FrmTransaction()
        {
            InitializeComponent();
        }

        private void FrmTransaction_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                string date = txtDate.Text;
                double amount = Convert.ToInt32(txtAmount.Text);
                t1 = new Transaction(id, date, amount);

                MessageBox.Show("Transaction done successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Caught !" + ex.Message);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                lblID.Text = " Transaction ID: " + t1.getID();
                lblDate.Text = "  Transaction Date: " + t1.getDate();
                lblAmount.Text=" Transaction Amount: "+ t1.getAmount();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Caught !" + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtDate.Clear();
            txtAmount.Clear();
            lblID.Text = " ";
            lblDate.Text = " ";
            lblAmount.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public interface ITransaction
    {
        int getID();
        string getDate();
        double getAmount();
    }

    public class Transaction :ITransaction
    {
        private int id;
        private string date;
        private double amount;

        public Transaction()
        {
            id = 0;
            date = " ";
            amount = 0.0;
        }
        public Transaction(int i,string d,double a)
        {
            id = i;
            date = d;
            amount = a;
        }
        public int getID()
        {
            return id;
        }
        public string  getDate()
        {
            return date;
        }
        public double getAmount()
        {
            return amount;
        }
    }
}
