using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asfd3sdawd2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen yellowPen = new Pen(Color.Yellow, 10);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            Font drawFont = new Font("OfficinaSansStd-Bold", 50, FontStyle.Bold);

            g.Clear(Color.White);

            g.DrawString("amazon", drawFont, blackBrush, 0, 0);
            g.DrawArc(yellowPen, 25, 40, 150, 75, 0, 180);
            g.FillPie(yellowBrush, 160, 60, 50, 25, 60, 120);
        }
    }
}
