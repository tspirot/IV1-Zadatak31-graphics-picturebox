using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak31
{
    public partial class Form1 : Form
    {
        Pen olovka = new Pen(Color.Black,1);
        int x1, y1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxBoja_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                olovka.Color = colorDialog1.Color;
                pictureBoxBoja.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            olovka.Width = listBoxDebljina.SelectedIndex + 1;
            int x2 = e.X;
            int y2 = e.Y;
            if (radioButtonElipsa.Checked)
            {
                int xGL = Math.Min(x1, x2);
                int yGL = Math.Min(y1, y2);
                g.DrawEllipse(olovka, xGL, yGL, Math.Abs(x1-x2)
                    , Math.Abs(y1 - y2));
            }
            if (radioButtonPravougaonik.Checked)
            {
                int xGL = Math.Min(x1, x2);
                int yGL = Math.Min(y1, y2);
                g.DrawRectangle(olovka, xGL, yGL, Math.Abs(x1 - x2)
                    , Math.Abs(y1 - y2));
            }
            if (radioButtonLinija.Checked)
                g.DrawLine(olovka, x1, y1, e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxDebljina.SelectedIndex = 0;
        }
    }
}
