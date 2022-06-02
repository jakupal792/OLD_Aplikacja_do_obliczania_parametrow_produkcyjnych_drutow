using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Druty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            double r, d0, d1;
            r = double.Parse(txtR.Text);
            d0 = double.Parse(txtD0.Text);
            d1 = double.Parse(txtD1.Text);
            double F = 0.6*d0*d0*Math.Sqrt((d0*d0-d1*d1)/(d0*d0))*r/2;
            txtF.Text = F.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d0ciagadlo, lambda;
            d0ciagadlo=double.Parse(txtD0ciagadlo.Text);
            lambda = double.Parse(txtLamb.Text);
            double Dciagadlo=Math.Sqrt(d0ciagadlo * d0ciagadlo / lambda);
            txtDciagadlo.Text = Dciagadlo.ToString();
        }
    }
}
