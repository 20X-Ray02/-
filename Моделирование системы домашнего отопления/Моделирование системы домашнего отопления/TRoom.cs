using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделирование_системы_домашнего_отопления
{
    public class TRoom
    {
        public string Name { get; }

        public int Temperature { get; set; }

        public int ValueTemperature { get; set; }

        public int ChangeValue { get; set; }

        public int CountClick { get; set; }

        public TRoom(string _name, int _change_temperature, int _count_click)
        {
            Name = _name;
            CountClick = _count_click;
            Temperature = _change_temperature/20;
        }

        public int ChangeTemperature(bool _automatic_control, bool _manual_control, bool _presence_people)
        {
            Random rnd_position = new Random();

            bool automaticControl = _automatic_control;
            bool manualControl = _manual_control;

            bool presencePeople = _presence_people;

            // Автоматическое поддержание температуры
            if (automaticControl)
            {
                // Если людей в комнате нет, поддерживать температуру ожидания
                if (presencePeople == false)
                {
                    if (Temperature > 22)
                    {
                        CountClick = 0;
                    }

                    if (Temperature < 18)
                    {
                        CountClick = rnd_position.Next(1, 3);
                    }

                    if (CountClick == 0)
                    {
                        ChangeValue = -1;
                    }

                    else if (CountClick == 1)
                    {
                        ChangeValue = 1;
                    }

                    else
                    {
                        ChangeValue = 2;
                    }
                }

                // Если в комнате есть люди, поддерживать рабочуую температуру
                if (presencePeople==true)
                {
                    if (Temperature > 27)
                    {
                        CountClick = 0;
                    }

                    if (Temperature < 23)
                    {
                        CountClick = rnd_position.Next(1, 3);
                    }

                    if (CountClick == 0)
                    {
                        ChangeValue = -1;
                    }

                    else if (CountClick == 1)
                    {
                        ChangeValue = 1;
                    }

                    else
                    {
                        ChangeValue = 2;
                    }
                }

            }

            // Ручное управление
            if (manualControl)
            {
                if (CountClick == 0)
                {
                    ChangeValue = -1;
                }

                else if (CountClick == 1)
                {
                    ChangeValue = 1;
                }

                else
                {
                    ChangeValue = 2;
                }
            }
            return ChangeValue;
        }

        public int GetTemperature()
        {
            return Temperature;
        }

        public int GetCountClick()
        {
            return CountClick;
        }

        public string StrTemperature()
        {
            return $"{Temperature}°C";
        }
    }
}
