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
    public partial class FrmIndexer : Form
    {
        private string[] myArray = new string[10];
        public FrmIndexer()
        {
            InitializeComponent();
        }
        private void FrmIndexer_Load(object sender, EventArgs e)
        {
            lblIndex.Text = " ";
        }
        public string this[int  index]
        {
            get
            {
                return myArray[index];
            }
            set
            {
                myArray[index] = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmIndexer indexer = new FrmIndexer();
            indexer[0] = "Ratnagiri";
            indexer[1] = "Rajapur";
            indexer[2] = "Lanja";
            indexer[3] = "Mandangad";

            lblIndex.Text = indexer[0] + "\n" + indexer[1];
        }
    }
}
