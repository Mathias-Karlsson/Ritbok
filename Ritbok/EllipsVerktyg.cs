using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritbok
{
    class EllipsVerktyg : RitVerktyg
    {
        public EllipsVerktyg(PictureBox pictureBox1) : base(pictureBox1)
        {
        }


        public override void MusDrag(int x, int y)
        {
        }

        public override void MusNer(int x, int y)
        {
            Coordinate c = new Coordinate(x, y);
            listOfXY.Add(c);
        }

        public override void MusUpp(int x, int y)
        {
            Coordinate first = listOfXY[0];
            listOfXY.Add(new Coordinate(first.X, y));
            listOfXY.Add(new Coordinate(x, y));
            listOfXY.Add(new Coordinate(x, first.Y));

            Bitmap pict = new Bitmap(pictureBox1.BackgroundImage);

            Graphics g = Graphics.FromImage(pict);
            Rita(pen, g);
            pictureBox1.BackgroundImage = pict;

            oldBitmaps.Add(pictureBox1.BackgroundImage);
            listOfXY.Clear();
        }

        public override void Rita(Pen p, Graphics g)
        {
            int maxX = Math.Max(Math.Max(listOfXY[0].X, listOfXY[1].X), Math.Max(listOfXY[2].X, listOfXY[3].X));
            int minX = Math.Min(Math.Min(listOfXY[0].X, listOfXY[1].X), Math.Min(listOfXY[2].X, listOfXY[3].X));
            int maxY = Math.Max(Math.Max(listOfXY[0].Y, listOfXY[1].Y), Math.Max(listOfXY[2].Y, listOfXY[3].Y));
            int minY = Math.Min(Math.Min(listOfXY[0].Y, listOfXY[1].Y), Math.Min(listOfXY[2].Y, listOfXY[3].Y));
            int width = maxX - minX;
            int height = maxY - minY;
            Rectangle rectangle = new Rectangle(minX, minY, width, height);
            g.DrawEllipse(pen, rectangle);
            g.Dispose();
        }
    }
}
