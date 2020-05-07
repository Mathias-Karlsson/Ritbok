using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritbok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bild = new Bitmap(800, 600);
            Graphics b = Graphics.FromImage(bild);
            b.DrawLine(Pens.Black, 10, 10, 300, 300);
            b.Dispose();
        }

        private void line_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void long_box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cube_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void triangel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
