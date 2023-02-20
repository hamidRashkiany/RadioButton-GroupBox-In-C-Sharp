using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J15RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            string[] txtFormColor = { "You selected ", "", " color for from's background!" };
            if (rdoBlue.Checked == true)
            {
                this.BackColor = Color.LightSkyBlue;
                txtFormColor[1] = Convert.ToString(this.BackColor.Name);
                label1.Text = string.Join("",txtFormColor);
                //label1.Text = "You selected blue color for form Background!"; (this is an static approach)
            }
            if (rdoRed.Checked == true)
            {
                this.BackColor = Color.Red;
                txtFormColor[1] = Convert.ToString(this.BackColor.Name);
                label1.Text = string.Join("", txtFormColor);
                //label1.Text = "You selected red color for form Background!";
            }
            if (rdoGreen.Checked == true)
            {
                this.BackColor = Color.ForestGreen;
                txtFormColor[1] = Convert.ToString(this.BackColor.Name);
                label1.Text = string.Join("", txtFormColor);
                //label1.Text = "You selected green color for form Background!";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoVioletColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVioletColor.Checked == true)
            {
                label1.ForeColor = Color.DarkViolet;
            }
        }

        private void rdoOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOrange.Checked == true)
            {
                label1.ForeColor = Color.Orange;
            }
        }
    }
}
