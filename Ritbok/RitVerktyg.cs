using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritbok
{

    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }


    public abstract class RitVerktyg
    {
        protected PictureBox pictureBox1;
        protected List<Coordinate> listOfXY;
        protected bool penDown = false;

        protected List<Image> oldBitmaps = new List<Image>();

        public RitVerktyg(PictureBox pictureBox)
        {
            this.pictureBox1 = pictureBox;
            if (pictureBox1.BackgroundImage == null)
            {
                Bitmap pict = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.BackgroundImage = pict;
            }
            this.listOfXY = new List<Coordinate>();
        }

        public abstract void MusNer(int x, int y);

        public abstract void MusUpp(int x, int y);

        public abstract void MusDrag(int x, int y);

        public abstract void Rita(Pen p, Graphics g);
    }
}
