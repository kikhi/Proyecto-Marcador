using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcador_TKD
{
    public partial class Form1 : Form
    {
        int tiempo = 60;
        int t_oro = 30;
        int rojo = 0;
        int azul = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
            if (e.KeyData == Keys.Space)
            {
                label1.Text = "Ronda 1";
                label2.Text = "0:00";
                label3.Text = "0";
                label4.Text = "0";
                tiempo = 60;
                t_oro = 30;
                rojo = 0;
                azul = 0;
                timer1.Stop();
                timer2.Stop();
            }
            if (e.KeyData == Keys.Z)
            {
                tiempo--;
                label2.Text = tiempo.ToString();
                timer1.Start();
            }
            if (e.KeyData == Keys.X)
            {
                timer1.Stop();
                timer2.Stop();
            }
            if (e.KeyData == Keys.C)
            {
                t_oro--;
                label2.Text = t_oro.ToString();
                timer2.Enabled = true;
            }
            if (e.KeyData == Keys.V)
            {
                timer1.Stop();
                timer2.Stop();
                tiempo = 60;
                t_oro = 30;
                label2.Text = "0:00";
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
                label1.Text = "Ronda 4";
            }
            if (e.KeyData == Keys.F5)
            {
                label1.Text = "Punto de Oro!";
            }
            if (e.KeyData == Keys.Q)
            {
                rojo ++;
                label3.Text = rojo.ToString();
                pictureBox3.Visible = true;
            }
            if (e.KeyData == Keys.W)
            {
                rojo += 2;
                label3.Text = rojo.ToString();
                pictureBox4.Visible = true;
            }
            if (e.KeyData == Keys.E)
            {
                rojo += 3;
                label3.Text = rojo.ToString();
                pictureBox5.Visible = true;
            }
            if (e.KeyData == Keys.R)
            {
                rojo -= 1;
                label3.Text = rojo.ToString();
            }
            if (e.KeyData == Keys.A)
            {
                azul ++;
                label4.Text = azul.ToString();
                pictureBox6.Visible = true;
            }
            if (e.KeyData == Keys.S)
            {
                azul += 2;
                label4.Text = azul.ToString();
                pictureBox7.Visible = true;
            }
            if (e.KeyData == Keys.D)
            {
                azul += 3;
                label4.Text = azul.ToString();
                pictureBox8.Visible = true;
            }
            if (e.KeyData == Keys.F)
            {
                azul -= 1;
                label4.Text = azul.ToString();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q)
            {
                pictureBox3.Visible = false;
            }
            if (e.KeyData == Keys.W)
            {
                pictureBox4.Visible = false;
            }
            if (e.KeyData == Keys.E)
            {
                pictureBox5.Visible = false;
            }
            if (e.KeyData == Keys.A)
            {
                pictureBox6.Visible = false;
            }
            if (e.KeyData == Keys.S)
            {
                pictureBox7.Visible = false;
            }
            if (e.KeyData == Keys.D)
            {
                pictureBox8.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo--;
            label2.Text = tiempo.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t_oro--;
            label2.Text = t_oro.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            timer1.Stop();
            timer2.Stop();
        }
    }
}
