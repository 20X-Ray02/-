using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделирование_системы_домашнего_отопления
{
    public class TValve
    {
        public int CountClick { get; set; }
        public System.Drawing.Bitmap ValveImage { get; set; }

        public TValve(int _count_click = 0)
        {
            CountClick = _count_click;
        }

        public System.Drawing.Bitmap GetPosition()
        {
            if (CountClick == 0)
            {
                ValveImage = Resource1.valve_close;
            }

            else if (CountClick == 1)
            {
                ValveImage = Resource1.valve_half_open;
            }

            else
            {
                ValveImage = Resource1.valve_open;
            }

            return ValveImage;
        }
        public int GetCountClick()
        {
            return CountClick;
        }
    }
}
