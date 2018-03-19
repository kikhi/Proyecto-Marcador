using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcador_Taekwondo_1._1
{
    public partial class Form1 : Form
    {
        private int conteo;
        private int oro;
        private int puncha;
        private int punchr;

        public Form1()
        {
            InitializeComponent();
            conteo = 60;
            oro = 30;
            puncha = 0;
            punchr = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q)
            {
                conteo--;
                label2.Text = conteo.ToString();
                timer1.Start();
            }
            if (e.KeyData == Keys.W)
            {
                timer1.Stop();
                timer2.Stop();

            }
            if (e.KeyData == Keys.E)
            {
                oro--;
                label2.Text = oro.ToString();
                timer2.Enabled = true;
            }
            if (e.KeyData == Keys.R)
            {
                conteo = 60;
                oro = 30;
            }
            if (e.KeyData == Keys.F1)
            {
                label1.Text = "Ronda 1";
            }
            if (e.KeyData == Keys.F2)
            {
                label1.Text = "Ronda 2";
            }
            if (e.KeyData == Keys.F3)
            {
                label1.Text = "Ronda 3";
            }
            if (e.KeyData == Keys.F4)
            {
                label1.Text = "Punto de ORO";
            }
            if (e.KeyData == Keys.P)
            {
                puncha++;
                label3.Text = puncha.ToString();
                pictureBox35.Visible = true;
            }
            if (e.KeyData == Keys.O)
            {
                puncha += 2;
                label3.Text = puncha.ToString();
                pictureBox32.Visible = true;
            }
            if (e.KeyData == Keys.I)
            {
                puncha += 3;
                label3.Text = puncha.ToString();
                pictureBox33.Visible = true;
            }
            if (e.KeyData == Keys.L)
            {
                punchr++;
                label4.Text = punchr.ToString();
                pictureBox18.Visible = true;
            }
            if (e.KeyData == Keys.K)
            {
                punchr += 2;
                label4.Text = punchr.ToString();
                pictureBox31.Visible = true;
            }
            if (e.KeyData == Keys.J)
            {
                punchr += 3;
                label4.Text = punchr.ToString();
                pictureBox34.Visible = true;
            }
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
            if (e.KeyData == Keys.M)
            {
                punchr -= 1;
                label4.Text = punchr.ToString();
            }
            if (e.KeyData == Keys.N)
            {
                puncha -= 1;
                label3.Text = puncha.ToString();
            }
            if (e.KeyData == Keys.A)
            {
                pictureBox3.Visible = true;
            }
            if (e.KeyData == Keys.S)
            {
                pictureBox4.Visible = true;
            }
            if (e.KeyData == Keys.D)
            {
                pictureBox6.Visible = true;
            }
            if (e.KeyData == Keys.F)
            {
                pictureBox5.Visible = true;
            }
            if (e.KeyData == Keys.Z)
            {
                pictureBox7.Visible = true;
            }
            if (e.KeyData == Keys.X)
            {
                pictureBox8.Visible = true;
            }
            if (e.KeyData == Keys.C)
            {
                pictureBox9.Visible = true;
            }
            if (e.KeyData == Keys.V)
            {
                pictureBox10.Visible = true;
            }
            if (e.KeyData == Keys.Space)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
            if (e.KeyData == Keys.T)
            {
                label2.Text = "0:00";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox18.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;

            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo--;
            label2.Text = conteo.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            oro--;
            label2.Text = oro.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.P)
            {
                pictureBox35.Visible = false;
            }
            if (e.KeyData == Keys.O)
            {
                pictureBox32.Visible = false;
            }
            if (e.KeyData == Keys.I)
            {
                pictureBox33.Visible = false;
            }
            if (e.KeyData == Keys.L)
            {
                pictureBox18.Visible = false;
            }
            if (e.KeyData == Keys.K)
            {
                pictureBox31.Visible = false;
            }
            if (e.KeyData == Keys.J)
            {
                pictureBox34.Visible = false;
            }
        }
    }
}
