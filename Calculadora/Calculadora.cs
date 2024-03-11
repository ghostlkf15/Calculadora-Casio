using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private double val1;
        private double val2;
        private double result;

        private double n1;
        private double n2;

        private int op;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "1";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "0";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "9";
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text = "";
        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
            op = 1;
            val1 = Convert.ToDouble(this.txt_pantalla.Text);
            this.txt_pantalla.Text = "";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            this.txt_pantalla.Text += "";
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            op = 2;
            val1 = Convert.ToDouble(this.txt_pantalla.Text);
            this.txt_pantalla.Text = "";
        }

        private void btn_por_Click(object sender, EventArgs e)
        {
            op = 3;
            val1 = Convert.ToDouble(this.txt_pantalla.Text);
            this.txt_pantalla.Text = "";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            op = 4;
            val1 = Convert.ToDouble(this.txt_pantalla.Text);
            this.txt_pantalla.Text = "";
        }

        private void btn_porcentaje_Click(object sender, EventArgs e)
        {
            op = 5;
            val1 = Convert.ToDouble(this.txt_pantalla.Text);
            this.txt_pantalla.Text = "";
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            op = 6;
            val1 = Convert.ToDouble(this.txt_pantalla.Text);
            this.txt_pantalla.Text = "";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            val2 = Convert.ToDouble(this.txt_pantalla.Text);

            switch (op)
            {
                case 1:
                    result = val1 + val2;
                break;

                case 2:
                    result = val1 - val2;
                break;

                case 3:
                    result = val1 * val2;
                break;

                case 4:
                    result = val1 / val2;
                break;

                case 5:
                    double f, a;
                    f = val2 / 100;
                    a = val1 * f;
                    result = val1 - a;
                break;

                case 6:
                    result = Math.Pow(val1, 1/ val2);
                break;
            }

            this.txt_pantalla.Text = result.ToString();
        }
    }
}
