using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorbo_Assignment_7
{
    class Room
    {
        public readonly int len;
        public readonly int wid;
        public readonly int high;
        public int area;
        public int gal;

        public Room(int len, int wid, int high)
        {
            this.len = len;
            this.wid = wid;
            this.high = high;

            area=Area(len, wid, high);
            gal = Gal(area);
        }

        public int Area(int len, int wid, int high)
        {
            area = (2 * (len * high)) + (2 * (wid * high));

            return area;
        }

        public int Gal(int area)
        {
            if (area % 350 == 0)
            {
                gal = area / 350;
            }
            else
            {
                gal = area / 350;
                gal += 1;
            }

            return gal;
        }
    }
}
