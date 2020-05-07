using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritbok
{
    public abstract class RitVerktyg
    {
        public abstract void MusNer(int x, int y);

        public abstract void MusUpp(int x, int y);

        public abstract void MusDrag(int x, int y);

        public abstract void Rita(Pen p, Graphics g);
    }
}
