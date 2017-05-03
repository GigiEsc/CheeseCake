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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numeroa;
        int numerob;
        string operacion; 
        private void b0_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "0";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "0";
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "1";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "2";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "3";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "4";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "5";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "6";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "7";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "8";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text == "")
            {
                txtresultado.Text = "9";
            }
            else
            {
                txtresultado.Text = txtresultado.Text + "9";
            }
        }

        private void bsuma_Click(object sender, EventArgs e)
        {
            numeroa = Convert.ToInt32(txtresultado.Text);
            operacion = "+";
            txtresultado.Clear(); 

        }


        private void bresta_Click(object sender, EventArgs e)
        {
            numeroa = Convert.ToInt32(txtresultado.Text);
            operacion = "-";
            txtresultado.Clear();

        }

        private void bborrar_Click(object sender, EventArgs e)
        {

            numeroa = 0; 
            numerob = 0; 
            txtresultado.Clear();
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            if (operacion == "+")
            {
                numerob = Convert.ToInt32(txtresultado.Text);
                txtresultado.Text = Convert.ToString(numerob + numeroa); 

            } else 
            {
                numerob = Convert.ToInt32(txtresultado.Text);
                txtresultado.Text = Convert.ToString(numerob - numeroa);
            }

        }

    }
}
