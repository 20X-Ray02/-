using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Моделирование_системы_домашнего_отопления
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int minute = 0;

        bool presence_people = false;
        int studyTMP = 22 * 20;
        int kitchenTMP = 25 * 20;
        int garageTMP = 20 * 20;
        int living_roomTMP = 22 * 20;
        int rest_room1TMP = 20 * 20;
        int rest_room2TMP = 20 * 20;
        int bed_roomTMP = 20 * 20;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Люди
            TFather father = new TFather("Father", minute);
            TMother mother = new TMother("Mother", minute);

            //  ----
            // |Часы|
            //  ----

            TClock clock = new TClock(minute);

            // Проверка времени на часах
            if (minute == 1440)
            {
                minute = 0;
            }

            minute++;
            label_clock.Text = clock.GetTime();

            //  -------
            // |Кабинет|
            //  -------
            
            TValve study_valve = new TValve(study_count_click);

            // Проверка положения клапана
            if (study_count_click > 2)
            {
                study_count_click = 0;
            }

            // Температура комнаты
            TRoom study = new TRoom("Рабочий кабинет", studyTMP, study_count_click);

            if (father.GetValueControlTemperature() == 1 | mother.GetValueControlTemperature() == 1)
            {
                presence_people = true;
            }

            else
            {
                presence_people = false;
            }

            studyTMP += study.ChangeTemperature(automatic_control_study, manual_control_study, presence_people);
            study_count_click = study.GetCountClick();

            // Вывод температуры и положение клапана в интерфейсе, людей
            label_temperature_study.Text = study.StrTemperature();
            study_button.Image = study_valve.GetPosition();


            //  -----
            // |Гараж|
            //  -----

            TValve garage_valve = new TValve(garage_count_click);

            if (garage_count_click > 2)
            {
                garage_count_click = 0;
            }

            TRoom garage = new TRoom("Гараж", garageTMP, garage_count_click);

            if (father.GetValueControlTemperature() == 3 | mother.GetValueControlTemperature() == 3)
            {
                presence_people = true;
            }

            else
            {
                presence_people = false;
            }

            garageTMP += garage.ChangeTemperature(automatic_control_garage, manual_control_garage, presence_people);
            garage_count_click = garage.GetCountClick();

            label_temperature_garage.Text = garage.StrTemperature();
            garage_button.Image = garage_valve.GetPosition();


            //  -----
            // |Кухня|
            //  -----

            TValve kitchen_valve = new TValve(kitchen_count_click);

            if (kitchen_count_click > 2)
            {
                kitchen_count_click = 0;
            }

            TRoom kitchen = new TRoom("Кухня", kitchenTMP, kitchen_count_click);

            if (father.GetValueControlTemperature() == 2 | mother.GetValueControlTemperature() == 2)
            {
                presence_people = true;
            }

            else
            {
                presence_people = false;
            }

            kitchenTMP += kitchen.ChangeTemperature(automatic_control_kitchen, manual_control_kitchen, presence_people);
            kitchen_count_click = kitchen.GetCountClick();

            label_temperature_kitchen.Text = kitchen.StrTemperature();
            kitchen_button.Image = kitchen_valve.GetPosition();


            //  --------
            // |Гостевая|
            //  --------

            TValve living_room_valve = new TValve(living_room_count_click);

            if (living_room_count_click > 2)
            {
                living_room_count_click = 0;
            }

            TRoom living_room = new TRoom("Гостевая", living_roomTMP, living_room_count_click);

            if (father.GetValueControlTemperature() == 4 | mother.GetValueControlTemperature() == 4)
            {
                presence_people = true;
            }

            else
            {
                presence_people = false;
            }

            living_roomTMP += living_room.ChangeTemperature(automatic_control_living_room, manual_control_living_room, presence_people);
            living_room_count_click = living_room.GetCountClick();

            label_temperature_living_room.Text = living_room.StrTemperature();
            living_room_button.Image = living_room_valve.GetPosition();


            //  --------
            // |Уборная1|
            //  --------

            TValve rest_room1_valve = new TValve(rest_room1_count_click);

            if (rest_room1_count_click > 2)
            {
                rest_room1_count_click = 0;
            }

            TRoom rest_room1 = new TRoom("Уборная1", rest_room1TMP, rest_room1_count_click);

            if (father.GetValueControlTemperature() == 5 | mother.GetValueControlTemperature() == 5)
            {
                presence_people = true;
            }

            else
            {
                presence_people = false;
            }

            rest_room1TMP += rest_room1.ChangeTemperature(automatic_control_rest_room1, manual_control_rest_room1, presence_people);
            rest_room1_count_click = rest_room1.GetCountClick();

            label_temperature_rest_room1.Text = rest_room1.StrTemperature();
            rest_room1_button.Image = rest_room1_valve.GetPosition();


            //  --------
            // |Уборная2|
            //  --------

            TValve rest_room2_valve = new TValve(rest_room2_count_click);

            if (rest_room2_count_click > 2)
            {
                rest_room2_count_click = 0;
            }

            TRoom rest_room2 = new TRoom("Уборная1", rest_room2TMP, rest_room2_count_click);

            if (father.GetValueControlTemperature() == 6 | mother.GetValueControlTemperature() == 6)
            {
                presence_people = true;
            }

            else
            {
                presence_people = false;
            }

            rest_room2TMP += rest_room2.ChangeTemperature(automatic_control_rest_room1, manual_control_rest_room1, presence_people);
            rest_room2_count_click = rest_room2.GetCountClick();

            label_temperature_rest_room2.Text = rest_room2.StrTemperature();
            rest_room2_button.Image = rest_room2_valve.GetPosition();


            //  -------
            // |Спальня|
            //  -------

            TValve bed_room_valve = new TValve(bed_room_count_click);

            if (bed_room_count_click > 2)
            {
                bed_room_count_click = 0;
            }

            TRoom bed_room = new TRoom("Спальня", bed_roomTMP, bed_room_count_click);

            if (father.GetValueControlTemperature() == 7 | mother.GetValueControlTemperature() == 7)
            {
                presence_people = true;
            }

            else
            {
                presence_people = false;
            }

            bed_roomTMP += bed_room.ChangeTemperature(automatic_control_bed_room, manual_control_bed_room, presence_people);
            bed_room_count_click = bed_room.GetCountClick();

            label_temperature_bed_room.Text = bed_room.StrTemperature();
            bed_room_button.Image = bed_room_valve.GetPosition();


            Father.Location = new System.Drawing.Point(father.GetX(), father.GetY());
            Mother.Location = new System.Drawing.Point(mother.GetX(), mother.GetY());

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            clock.Enabled = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            clock.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        int study_count_click = 0;
        private void valve_button_Click(object sender, EventArgs e)
        {
            study_count_click++;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        bool automatic_control_study = true;
        bool manual_control_study = false;
        private void button1_Click(object sender, EventArgs e)
        {
            automatic_control_study = true;
            manual_control_study = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manual_control_study = true;
            automatic_control_study = false;
        }

        private void label_temperature_study_Click(object sender, EventArgs e)
        {

        }

        private void human_picture_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        int rest_room1_count_click = 0;
        private void rest_room1_button_Click(object sender, EventArgs e)
        {
            rest_room1_count_click++;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int rest_room2_count_click = 0;
        private void rest_room2_button_Click(object sender, EventArgs e)
        {
            rest_room2_count_click++;
        }

        private void manual1_button_Click(object sender, EventArgs e)
        {
            automatic_control_kitchen = true;
            manual_control_kitchen = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            automatic_control_living_room = false;
            manual_control_living_room = true;
        }

        bool automatic_control_rest_room1 = true;
        bool manual_control_rest_room1 = false;
        private void button3_Click(object sender, EventArgs e)
        {
            automatic_control_rest_room1 = true;
            manual_control_rest_room1 = false;
        }

        bool automatic_control_rest_room2 = true;
        bool manual_control_rest_room2 = false;
        private void button5_Click(object sender, EventArgs e)
        {
            automatic_control_rest_room2 = true;
            manual_control_rest_room2 = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            automatic_control_rest_room2 = false;
            manual_control_rest_room2 = true;
        }

        bool automatic_control_bed_room = true;
        bool manual_control_bed_room = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            automatic_control_bed_room = true;
            manual_control_bed_room = false;
        }

        int garage_count_click = 0;
        private void garage_button_Click(object sender, EventArgs e)
        {
            garage_count_click++;
        }

        bool automatic_control_garage = true;
        bool manual_control_garage = false;
        private void automatic2_button_Click(object sender, EventArgs e)
        {
            automatic_control_garage = true;
            manual_control_garage = false;
        }

        private void manual2_button_Click(object sender, EventArgs e)
        {
            manual_control_garage = true;
            automatic_control_garage = false;
        }

        int kitchen_count_click = 0;
        private void kitchen_button_Click(object sender, EventArgs e)
        {
            kitchen_count_click++;
        }

        bool automatic_control_kitchen = true;
        bool manual_control_kitchen = false;
        private void automatic1_button_Click(object sender, EventArgs e)
        {
            automatic_control_kitchen = true;
            manual_control_kitchen = false;
        }

        int living_room_count_click = 0;
        private void living_room_button_Click(object sender, EventArgs e)
        {
            living_room_count_click++;
        }

        bool automatic_control_living_room = true;
        bool manual_control_living_room = false;
        private void automatic3_button_Click(object sender, EventArgs e)
        {
            automatic_control_living_room = true;
            manual_control_living_room = false;
        }

        private void manual4_button_Click(object sender, EventArgs e)
        {
            automatic_control_rest_room1 = false;
            manual_control_rest_room1 = true;
        }

        int bed_room_count_click = 0;
        private void bed_room_button_Click(object sender, EventArgs e)
        {
            bed_room_count_click++;
        }

        private void manual6_button_Click(object sender, EventArgs e)
        {
            automatic_control_bed_room = false;
            manual_control_bed_room = true;
        }
    }
}
