using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilla
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int n = num;
            String ju1, ju2,ju3,ju4,ju5,ju6;
            ju1 = tju1.Text;
            ju2 = tju2.Text;
            ju3 = tju3.Text;
            ju4 = tju4.Text;
            ju5 = tju5.Text;
            ju6 = tju6.Text;
            Planilla p = new Planilla(n,ju1,ju2,ju3,ju4,ju5,ju6);
            p.Visible = true;
            Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.E)
            {
                MessageBox.Show("Hecho por Harold Esteban Montaño Torres ©");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                num = 1;
                ju1.Visible = true;
                tju1.Visible = true;
                ju2.Visible = false;
                tju2.Visible = false;
                ju3.Visible = false;
                tju3.Visible = false;
                ju4.Visible = false;
                tju4.Visible = false;
                ju5.Visible = false;
                tju5.Visible = false;
                ju6.Visible = false;
                tju6.Visible = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                num = 2;
                ju1.Visible = true;
                tju1.Visible = true;
                ju2.Visible = true;
                tju2.Visible = true;
                ju3.Visible = false;
                tju3.Visible = false;
                ju4.Visible = false;
                tju4.Visible = false;
                ju5.Visible = false;
                tju5.Visible = false;
                ju6.Visible = false;
                tju6.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                num = 3;
                ju1.Visible = true;
                tju1.Visible = true;
                ju2.Visible = true;
                tju2.Visible = true;
                ju3.Visible = true;
                tju3.Visible = true;
                ju4.Visible = false;
                tju4.Visible = false;
                ju5.Visible = false;
                tju5.Visible = false;
                ju6.Visible = false;
                tju6.Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                num = 4;
                ju1.Visible = true;
                tju1.Visible = true;
                ju2.Visible = true;
                tju2.Visible = true;
                ju3.Visible = true;
                tju3.Visible = true;
                ju4.Visible = true;
                tju4.Visible = true;
                ju5.Visible = false;
                tju5.Visible = false;
                ju6.Visible = false;
                tju6.Visible = false;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                num = 5;
                ju1.Visible = true;
                tju1.Visible = true;
                ju2.Visible = true;
                tju2.Visible = true;
                ju3.Visible = true;
                tju3.Visible = true;
                ju4.Visible = true;
                tju4.Visible = true;
                ju5.Visible = true;
                tju5.Visible = true;
                ju6.Visible = false;
                tju6.Visible = false;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                num = 6;
                ju1.Visible = true;
                tju1.Visible = true;
                ju2.Visible = true;
                tju2.Visible = true;
                ju3.Visible = true;
                tju3.Visible = true;
                ju4.Visible = true;
                tju4.Visible = true;
                ju5.Visible = true;
                tju5.Visible = true;
                ju6.Visible = true;
                tju6.Visible = true;
            }


        }
    }
}
