using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделирование_системы_домашнего_отопления
{
    internal class TFather : THuman
    {
        public TFather(string _family_member, int _minute) : base(_family_member, _minute)
        {
            Random rndX = new Random(Guid.NewGuid().GetHashCode());
            Random rndY = new Random(Guid.NewGuid().GetHashCode());

            if (Minute < 120)
            {
                X = rndX.Next(Cordinates[0][0], Cordinates[0][2]);
                Y = rndY.Next(Cordinates[0][1], Cordinates[0][3]);
            }

            else if (Minute < 420)
            {
                X = Cordinates[4][0];
                Y = Cordinates[4][1];
            }

            else if (Minute < 480)
            {
                X = rndX.Next(Cordinates[2][0], Cordinates[2][2]);
                Y = rndY.Next(Cordinates[2][1], Cordinates[2][3]);
            }

            else if (Minute > 1080 & Minute < 1140)
            {
                X = rndX.Next(Cordinates[1][0], Cordinates[1][2]);
                Y = rndY.Next(Cordinates[1][1], Cordinates[1][3]);
            }

            else if (Minute > 1150 & Minute < 1260)
            {
                X = rndX.Next(Cordinates[2][0], Cordinates[2][2]);
                Y = rndY.Next(Cordinates[2][1], Cordinates[2][3]);
            }

            else if (Minute > 1260 & Minute < 1320)
            {
                X = rndX.Next(Cordinates[3][0], Cordinates[3][2]);
                Y = rndY.Next(Cordinates[3][1], Cordinates[3][3]);
            }

            else if (Minute > 1320 & Minute < 1440)
            {
                X = rndX.Next(Cordinates[0][0], Cordinates[0][2]);
                Y = rndY.Next(Cordinates[0][1], Cordinates[0][3]);
            }

            else
            {
                X = 1000;
                Y = 1000;
            }
        }
    }
}
