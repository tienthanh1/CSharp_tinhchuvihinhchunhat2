using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_tinhchuvihinhchunhat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double ngang, doc, kp;
            ngang = Convert.ToDouble(txtngang.Text);
            doc = Convert.ToDouble(txtdoc.Text);
            kp = ngang * doc;
            txtketqua.Text = kp.ToString();
        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            Double ngang, doc, kp;
            ngang = Convert.ToDouble(txtngang.Text);
            doc = Convert.ToDouble(txtdoc.Text);
            kp = (ngang + doc) * 2;
            txtketqua.Text = kp.ToString();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbChuvi_CheckedChanged(object sender, EventArgs e)
        {
            Double ngang, doc, kp;
            ngang = Convert.ToDouble(txtngang.Text);
            doc = Convert.ToDouble(txtdoc.Text);
            kp = (ngang + doc) * 2;
            txtketqua.Text = kp.ToString();
        }

        private void rdbDientich_CheckedChanged(object sender, EventArgs e)
        {
            if (txtngang.Text == "" || txtdoc.Text == "")
            {
                MessageBox.Show("Phải nhập ngang và dọc");
            }
            Double ngang, doc, kp;
            ngang = Convert.ToDouble(txtngang.Text);
            doc = Convert.ToDouble(txtdoc.Text);
            kp = ngang * doc;
            txtketqua.Text = kp.ToString();
        }
    }
}
