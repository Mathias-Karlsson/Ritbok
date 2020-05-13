using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritbok
{
    class PennVerktyg : RitVerktyg
    {
        public override void MusDrag(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void MusNer(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void MusUpp(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void Rita(Pen p, Graphics g)
        {
            Bitmap bild = new Bitmap(800, 600);
            Graphics b = Graphics.FromImage(bild);
            b.DrawLine(Pens.Black, 10, 10, 300, 300);
            b.Dispose();
        }
    }
}
