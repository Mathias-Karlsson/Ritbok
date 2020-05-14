using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritbok
{
    class PennVerktyg : RitVerktyg
    {
        public PennVerktyg(PictureBox pictureBox1) : base(pictureBox1)
        {
        }


        public override void MusDrag(int x, int y)
        {
            if (penDown == true)
            {
                Bitmap pict = new Bitmap(pictureBox1.BackgroundImage);

                Graphics g = Graphics.FromImage(pict);
                Rita(Pens.Black, g);
                pictureBox1.BackgroundImage = pict;

                Coordinate c = new Coordinate(x, y);
                listOfXY.Add(c);
            }
        }

        public override void MusNer(int x, int y)
        {
            penDown = true;
            Coordinate c = new Coordinate(x, y);
            listOfXY.Add(c);
        }

        public override void MusUpp(int x, int y)
        {
            penDown = false;
            listOfXY.Clear();
            oldBitmaps.Add(pictureBox1.BackgroundImage);
        }

        public override void Rita(Pen p, Graphics g)
        {
            for (int i = 0; i < listOfXY.Count - 1; i++)
            {
                g.DrawLine(Pens.Black, listOfXY[i].X, listOfXY[i].Y, listOfXY[i + 1].X, listOfXY[i + 1].Y);
            }
            g.Dispose();
        }
    }
}
