using System;
using System.Collections.Generic;

namespace Моделирование_системы_домашнего_отопления
{
    internal class THuman
    {
        public string FamilyMember { get; }
        public int Minute { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public List<List<int>> Cordinates { get; set; } = new List<List<int>>();

        public THuman (string _family_member, int _minute)
        {
            FamilyMember = _family_member;
            Minute = _minute;

            Cordinates.Add(new List<int>() { 507, 9, 710, 175 }); // Кабинет
            Cordinates.Add(new List<int>() { 503, 281, 712, 628 }); // Гараж
            Cordinates.Add(new List<int>() { 12, 47, 163, 210 }); // Кухня
            Cordinates.Add(new List<int>() { 12, 253, 213, 628}); // Гостинная
            Cordinates.Add(new List<int>() { 422, 577}); // Спальня
            Cordinates.Add(new List<int>() { 354, 523, 450, 309}); // Уборная 1
            Cordinates.Add(new List<int>() { 354, 368, 450, 425}); // Уборная 2
        }

        public int GetValueControlTemperature()
        {
            if (X > Cordinates[0][0] & X < Cordinates[0][2] & Y > Cordinates[0][1] & Y < Cordinates[0][3])
            {
                return 1;
            }

            else if (X > Cordinates[2][0] & X < Cordinates[2][2] & Y > Cordinates[2][1] & Y < Cordinates[2][3])
            {
                return 2;
            }

            else if (X > Cordinates[1][0] & X < Cordinates[1][2] & Y > Cordinates[1][1] & Y < Cordinates[1][3])
            {
                return 3;
            }

            else if (X > Cordinates[3][0] & X < Cordinates[3][2] & Y > Cordinates[3][1] & Y < Cordinates[3][3])
            {
                return 4;
            }

            else if (X == Cordinates[4][0] & Y == Cordinates[4][1])
            {
                return 7;
            }

            return 0;
        }

        public string GetFamilyMember()
        {
            return $"Член семьи: {FamilyMember}";
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }


    }
}
