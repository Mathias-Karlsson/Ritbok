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
        RitVerktyg ritVerktyg;


        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.MusNer(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.MusNer(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.MusNer(e.X, e.Y);
            }
        }

        private void line_CheckedChanged(object sender, EventArgs e)
        {
            ritVerktyg = new LinjeVerktyg(pictureBox1);
        }

        private void long_box_CheckedChanged(object sender, EventArgs e)
        {
            ritVerktyg = new RektangelVerktyg(pictureBox1);
        }

        private void cube_CheckedChanged(object sender, EventArgs e)
        {
            ritVerktyg = new EllipsVerktyg(pictureBox1);
        }

        private void triangel_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pen_CheckedChanged(object sender, EventArgs e)
        {
            ritVerktyg = new PennVerktyg(pictureBox1);
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.MusNer(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.MusDrag(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.MusUpp(e.X, e.Y);
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.Undo();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.Red();
            }
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.Black();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (ritVerktyg != null)
            {
                ritVerktyg.Blue();
            }
        }

        private void pensize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RitVerktyg.pen.Width = Convert.ToInt32(pensize.Text);
            }
            catch (Exception)
            {
                pensize.Text = "1";
                RitVerktyg.pen.Width = 1;
            }
        }
    }
}
