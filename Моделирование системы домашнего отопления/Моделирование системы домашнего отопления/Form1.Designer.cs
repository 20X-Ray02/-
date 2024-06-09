
namespace Моделирование_системы_домашнего_отопления
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_clock = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.Father = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.manual0_button = new System.Windows.Forms.Button();
            this.automatic0_button = new System.Windows.Forms.Button();
            this.label_temperature_study = new System.Windows.Forms.Label();
            this.study_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.manual1_button = new System.Windows.Forms.Button();
            this.automatic1_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label_temperature_kitchen = new System.Windows.Forms.Label();
            this.kitchen_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.manual2_button = new System.Windows.Forms.Button();
            this.automatic2_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label_temperature_garage = new System.Windows.Forms.Label();
            this.garage_button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.manual3_button = new System.Windows.Forms.Button();
            this.automatic3_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label_temperature_living_room = new System.Windows.Forms.Label();
            this.living_room_button = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.manual4_button = new System.Windows.Forms.Button();
            this.automatic4_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label_temperature_rest_room1 = new System.Windows.Forms.Label();
            this.rest_room1_button = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.manual5_button = new System.Windows.Forms.Button();
            this.automatic5_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label_temperature_rest_room2 = new System.Windows.Forms.Label();
            this.rest_room2_button = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.manual6_button = new System.Windows.Forms.Button();
            this.automatic6_button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label_temperature_bed_room = new System.Windows.Forms.Label();
            this.bed_room_button = new System.Windows.Forms.Button();
            this.Mother = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Father)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mother)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Моделирование_системы_домашнего_отопления.Resource1.background;
            this.pictureBox1.Location = new System.Drawing.Point(1, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 753);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_clock.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clock.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_clock.Location = new System.Drawing.Point(980, 9);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(89, 29);
            this.label_clock.TabIndex = 1;
            this.label_clock.Text = "hh:mm";
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonStart.Image")));
            this.buttonStart.Location = new System.Drawing.Point(1006, 594);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(185, 67);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.White;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Image = global::Моделирование_системы_домашнего_отопления.Resource1.pause;
            this.pause.Location = new System.Drawing.Point(917, 594);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(83, 67);
            this.pause.TabIndex = 3;
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // Father
            // 
            this.Father.Image = global::Моделирование_системы_домашнего_отопления.Resource1.human00;
            this.Father.Location = new System.Drawing.Point(696, 684);
            this.Father.Name = "Father";
            this.Father.Size = new System.Drawing.Size(39, 33);
            this.Father.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Father.TabIndex = 5;
            this.Father.TabStop = false;
            this.Father.Click += new System.EventHandler(this.human_picture_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.manual0_button);
            this.groupBox1.Controls.Add(this.automatic0_button);
            this.groupBox1.Controls.Add(this.label_temperature_study);
            this.groupBox1.Controls.Add(this.study_button);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(790, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кабинет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(32, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Control";
            // 
            // manual0_button
            // 
            this.manual0_button.Location = new System.Drawing.Point(20, 128);
            this.manual0_button.Name = "manual0_button";
            this.manual0_button.Size = new System.Drawing.Size(75, 23);
            this.manual0_button.TabIndex = 3;
            this.manual0_button.Text = "manual";
            this.manual0_button.UseVisualStyleBackColor = true;
            this.manual0_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // automatic0_button
            // 
            this.automatic0_button.Location = new System.Drawing.Point(20, 101);
            this.automatic0_button.Name = "automatic0_button";
            this.automatic0_button.Size = new System.Drawing.Size(75, 23);
            this.automatic0_button.TabIndex = 2;
            this.automatic0_button.Text = "automatic";
            this.automatic0_button.UseVisualStyleBackColor = true;
            this.automatic0_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_temperature_study
            // 
            this.label_temperature_study.AutoSize = true;
            this.label_temperature_study.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperature_study.ForeColor = System.Drawing.Color.Red;
            this.label_temperature_study.Location = new System.Drawing.Point(62, 40);
            this.label_temperature_study.Name = "label_temperature_study";
            this.label_temperature_study.Size = new System.Drawing.Size(30, 17);
            this.label_temperature_study.TabIndex = 1;
            this.label_temperature_study.Text = "°C";
            this.label_temperature_study.Click += new System.EventHandler(this.label_temperature_study_Click);
            // 
            // study_button
            // 
            this.study_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.study_button.Location = new System.Drawing.Point(6, 24);
            this.study_button.Name = "study_button";
            this.study_button.Size = new System.Drawing.Size(50, 50);
            this.study_button.TabIndex = 0;
            this.study_button.UseVisualStyleBackColor = true;
            this.study_button.Click += new System.EventHandler(this.valve_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.manual1_button);
            this.groupBox2.Controls.Add(this.automatic1_button);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label_temperature_kitchen);
            this.groupBox2.Controls.Add(this.kitchen_button);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(966, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 157);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кухня";
            // 
            // manual1_button
            // 
            this.manual1_button.Location = new System.Drawing.Point(18, 128);
            this.manual1_button.Name = "manual1_button";
            this.manual1_button.Size = new System.Drawing.Size(75, 23);
            this.manual1_button.TabIndex = 5;
            this.manual1_button.Text = "manual";
            this.manual1_button.UseVisualStyleBackColor = true;
            this.manual1_button.Click += new System.EventHandler(this.manual1_button_Click);
            // 
            // automatic1_button
            // 
            this.automatic1_button.Location = new System.Drawing.Point(18, 101);
            this.automatic1_button.Name = "automatic1_button";
            this.automatic1_button.Size = new System.Drawing.Size(75, 23);
            this.automatic1_button.TabIndex = 4;
            this.automatic1_button.Text = "automatic";
            this.automatic1_button.UseVisualStyleBackColor = true;
            this.automatic1_button.Click += new System.EventHandler(this.automatic1_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(37, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Control";
            // 
            // label_temperature_kitchen
            // 
            this.label_temperature_kitchen.AutoSize = true;
            this.label_temperature_kitchen.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperature_kitchen.ForeColor = System.Drawing.Color.Red;
            this.label_temperature_kitchen.Location = new System.Drawing.Point(63, 40);
            this.label_temperature_kitchen.Name = "label_temperature_kitchen";
            this.label_temperature_kitchen.Size = new System.Drawing.Size(30, 17);
            this.label_temperature_kitchen.TabIndex = 2;
            this.label_temperature_kitchen.Text = "°C";
            this.label_temperature_kitchen.Click += new System.EventHandler(this.label1_Click);
            // 
            // kitchen_button
            // 
            this.kitchen_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitchen_button.Location = new System.Drawing.Point(6, 24);
            this.kitchen_button.Name = "kitchen_button";
            this.kitchen_button.Size = new System.Drawing.Size(50, 50);
            this.kitchen_button.TabIndex = 0;
            this.kitchen_button.UseVisualStyleBackColor = true;
            this.kitchen_button.Click += new System.EventHandler(this.kitchen_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.manual2_button);
            this.groupBox3.Controls.Add(this.automatic2_button);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label_temperature_garage);
            this.groupBox3.Controls.Add(this.garage_button);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1140, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 154);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Гараж";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // manual2_button
            // 
            this.manual2_button.Location = new System.Drawing.Point(27, 127);
            this.manual2_button.Name = "manual2_button";
            this.manual2_button.Size = new System.Drawing.Size(75, 23);
            this.manual2_button.TabIndex = 4;
            this.manual2_button.Text = "manual";
            this.manual2_button.UseVisualStyleBackColor = true;
            this.manual2_button.Click += new System.EventHandler(this.manual2_button_Click);
            // 
            // automatic2_button
            // 
            this.automatic2_button.Location = new System.Drawing.Point(27, 100);
            this.automatic2_button.Name = "automatic2_button";
            this.automatic2_button.Size = new System.Drawing.Size(75, 23);
            this.automatic2_button.TabIndex = 3;
            this.automatic2_button.Text = "automatic";
            this.automatic2_button.UseVisualStyleBackColor = true;
            this.automatic2_button.Click += new System.EventHandler(this.automatic2_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(37, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Control";
            // 
            // label_temperature_garage
            // 
            this.label_temperature_garage.AutoSize = true;
            this.label_temperature_garage.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperature_garage.ForeColor = System.Drawing.Color.Red;
            this.label_temperature_garage.Location = new System.Drawing.Point(62, 42);
            this.label_temperature_garage.Name = "label_temperature_garage";
            this.label_temperature_garage.Size = new System.Drawing.Size(30, 17);
            this.label_temperature_garage.TabIndex = 1;
            this.label_temperature_garage.Text = "°C";
            this.label_temperature_garage.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // garage_button
            // 
            this.garage_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.garage_button.Location = new System.Drawing.Point(6, 25);
            this.garage_button.Name = "garage_button";
            this.garage_button.Size = new System.Drawing.Size(50, 50);
            this.garage_button.TabIndex = 0;
            this.garage_button.UseVisualStyleBackColor = true;
            this.garage_button.Click += new System.EventHandler(this.garage_button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.manual3_button);
            this.groupBox4.Controls.Add(this.automatic3_button);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label_temperature_living_room);
            this.groupBox4.Controls.Add(this.living_room_button);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(790, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 154);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Гостевая";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // manual3_button
            // 
            this.manual3_button.Location = new System.Drawing.Point(20, 125);
            this.manual3_button.Name = "manual3_button";
            this.manual3_button.Size = new System.Drawing.Size(75, 23);
            this.manual3_button.TabIndex = 6;
            this.manual3_button.Text = "manual";
            this.manual3_button.UseVisualStyleBackColor = true;
            this.manual3_button.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // automatic3_button
            // 
            this.automatic3_button.Location = new System.Drawing.Point(20, 101);
            this.automatic3_button.Name = "automatic3_button";
            this.automatic3_button.Size = new System.Drawing.Size(75, 23);
            this.automatic3_button.TabIndex = 5;
            this.automatic3_button.Text = "automatic";
            this.automatic3_button.UseVisualStyleBackColor = true;
            this.automatic3_button.Click += new System.EventHandler(this.automatic3_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(31, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Control";
            // 
            // label_temperature_living_room
            // 
            this.label_temperature_living_room.AutoSize = true;
            this.label_temperature_living_room.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperature_living_room.ForeColor = System.Drawing.Color.Red;
            this.label_temperature_living_room.Location = new System.Drawing.Point(62, 43);
            this.label_temperature_living_room.Name = "label_temperature_living_room";
            this.label_temperature_living_room.Size = new System.Drawing.Size(30, 17);
            this.label_temperature_living_room.TabIndex = 3;
            this.label_temperature_living_room.Text = "°C";
            this.label_temperature_living_room.Click += new System.EventHandler(this.label3_Click);
            // 
            // living_room_button
            // 
            this.living_room_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.living_room_button.Location = new System.Drawing.Point(6, 26);
            this.living_room_button.Name = "living_room_button";
            this.living_room_button.Size = new System.Drawing.Size(50, 50);
            this.living_room_button.TabIndex = 2;
            this.living_room_button.UseVisualStyleBackColor = true;
            this.living_room_button.Click += new System.EventHandler(this.living_room_button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.manual4_button);
            this.groupBox5.Controls.Add(this.automatic4_button);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label_temperature_rest_room1);
            this.groupBox5.Controls.Add(this.rest_room1_button);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(966, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(119, 154);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Уборная1";
            // 
            // manual4_button
            // 
            this.manual4_button.Location = new System.Drawing.Point(18, 125);
            this.manual4_button.Name = "manual4_button";
            this.manual4_button.Size = new System.Drawing.Size(75, 23);
            this.manual4_button.TabIndex = 4;
            this.manual4_button.Text = "manual";
            this.manual4_button.UseVisualStyleBackColor = true;
            this.manual4_button.Click += new System.EventHandler(this.manual4_button_Click);
            // 
            // automatic4_button
            // 
            this.automatic4_button.Location = new System.Drawing.Point(18, 101);
            this.automatic4_button.Name = "automatic4_button";
            this.automatic4_button.Size = new System.Drawing.Size(75, 23);
            this.automatic4_button.TabIndex = 3;
            this.automatic4_button.Text = "automatic";
            this.automatic4_button.UseVisualStyleBackColor = true;
            this.automatic4_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(33, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Control";
            // 
            // label_temperature_rest_room1
            // 
            this.label_temperature_rest_room1.AutoSize = true;
            this.label_temperature_rest_room1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperature_rest_room1.ForeColor = System.Drawing.Color.Red;
            this.label_temperature_rest_room1.Location = new System.Drawing.Point(62, 43);
            this.label_temperature_rest_room1.Name = "label_temperature_rest_room1";
            this.label_temperature_rest_room1.Size = new System.Drawing.Size(30, 17);
            this.label_temperature_rest_room1.TabIndex = 1;
            this.label_temperature_rest_room1.Text = "°C";
            // 
            // rest_room1_button
            // 
            this.rest_room1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rest_room1_button.Location = new System.Drawing.Point(6, 26);
            this.rest_room1_button.Name = "rest_room1_button";
            this.rest_room1_button.Size = new System.Drawing.Size(50, 50);
            this.rest_room1_button.TabIndex = 0;
            this.rest_room1_button.UseVisualStyleBackColor = true;
            this.rest_room1_button.Click += new System.EventHandler(this.rest_room1_button_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.manual5_button);
            this.groupBox6.Controls.Add(this.automatic5_button);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label_temperature_rest_room2);
            this.groupBox6.Controls.Add(this.rest_room2_button);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1140, 253);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(121, 154);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Уборная2";
            // 
            // manual5_button
            // 
            this.manual5_button.Location = new System.Drawing.Point(27, 125);
            this.manual5_button.Name = "manual5_button";
            this.manual5_button.Size = new System.Drawing.Size(75, 23);
            this.manual5_button.TabIndex = 17;
            this.manual5_button.Text = "manual";
            this.manual5_button.UseVisualStyleBackColor = true;
            this.manual5_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // automatic5_button
            // 
            this.automatic5_button.Location = new System.Drawing.Point(27, 101);
            this.automatic5_button.Name = "automatic5_button";
            this.automatic5_button.Size = new System.Drawing.Size(75, 23);
            this.automatic5_button.TabIndex = 16;
            this.automatic5_button.Text = "automatic";
            this.automatic5_button.UseVisualStyleBackColor = true;
            this.automatic5_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(37, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Control";
            // 
            // label_temperature_rest_room2
            // 
            this.label_temperature_rest_room2.AutoSize = true;
            this.label_temperature_rest_room2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperature_rest_room2.ForeColor = System.Drawing.Color.Red;
            this.label_temperature_rest_room2.Location = new System.Drawing.Point(62, 43);
            this.label_temperature_rest_room2.Name = "label_temperature_rest_room2";
            this.label_temperature_rest_room2.Size = new System.Drawing.Size(30, 17);
            this.label_temperature_rest_room2.TabIndex = 14;
            this.label_temperature_rest_room2.Text = "°C";
            // 
            // rest_room2_button
            // 
            this.rest_room2_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rest_room2_button.Location = new System.Drawing.Point(6, 26);
            this.rest_room2_button.Name = "rest_room2_button";
            this.rest_room2_button.Size = new System.Drawing.Size(50, 50);
            this.rest_room2_button.TabIndex = 13;
            this.rest_room2_button.UseVisualStyleBackColor = true;
            this.rest_room2_button.Click += new System.EventHandler(this.rest_room2_button_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox7.Controls.Add(this.manual6_button);
            this.groupBox7.Controls.Add(this.automatic6_button);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label_temperature_bed_room);
            this.groupBox7.Controls.Add(this.bed_room_button);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(966, 425);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(119, 154);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Спальня";
            // 
            // manual6_button
            // 
            this.manual6_button.Location = new System.Drawing.Point(28, 125);
            this.manual6_button.Name = "manual6_button";
            this.manual6_button.Size = new System.Drawing.Size(75, 23);
            this.manual6_button.TabIndex = 4;
            this.manual6_button.Text = "manual";
            this.manual6_button.UseVisualStyleBackColor = true;
            this.manual6_button.Click += new System.EventHandler(this.manual6_button_Click);
            // 
            // automatic6_button
            // 
            this.automatic6_button.Location = new System.Drawing.Point(28, 102);
            this.automatic6_button.Name = "automatic6_button";
            this.automatic6_button.Size = new System.Drawing.Size(75, 23);
            this.automatic6_button.TabIndex = 3;
            this.automatic6_button.Text = "automatic";
            this.automatic6_button.UseVisualStyleBackColor = true;
            this.automatic6_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(33, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Control";
            // 
            // label_temperature_bed_room
            // 
            this.label_temperature_bed_room.AutoSize = true;
            this.label_temperature_bed_room.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperature_bed_room.ForeColor = System.Drawing.Color.Red;
            this.label_temperature_bed_room.Location = new System.Drawing.Point(62, 44);
            this.label_temperature_bed_room.Name = "label_temperature_bed_room";
            this.label_temperature_bed_room.Size = new System.Drawing.Size(30, 17);
            this.label_temperature_bed_room.TabIndex = 1;
            this.label_temperature_bed_room.Text = "°C";
            // 
            // bed_room_button
            // 
            this.bed_room_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bed_room_button.Location = new System.Drawing.Point(6, 27);
            this.bed_room_button.Name = "bed_room_button";
            this.bed_room_button.Size = new System.Drawing.Size(50, 50);
            this.bed_room_button.TabIndex = 0;
            this.bed_room_button.UseVisualStyleBackColor = true;
            this.bed_room_button.Click += new System.EventHandler(this.bed_room_button_Click);
            // 
            // Mother
            // 
            this.Mother.Image = global::Моделирование_системы_домашнего_отопления.Resource1.human01;
            this.Mother.Location = new System.Drawing.Point(631, 684);
            this.Mother.Name = "Mother";
            this.Mother.Size = new System.Drawing.Size(45, 32);
            this.Mother.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mother.TabIndex = 13;
            this.Mother.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 729);
            this.Controls.Add(this.Mother);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Father);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label_clock);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Моделирование системы домашнего отопления";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Father)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mother)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_clock;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.PictureBox Father;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_temperature_study;
        private System.Windows.Forms.Button study_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_temperature_kitchen;
        private System.Windows.Forms.Button kitchen_button;
        private System.Windows.Forms.Label label_temperature_garage;
        private System.Windows.Forms.Button garage_button;
        private System.Windows.Forms.Label label_temperature_living_room;
        private System.Windows.Forms.Button living_room_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_temperature_rest_room1;
        private System.Windows.Forms.Button rest_room1_button;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label_temperature_rest_room2;
        private System.Windows.Forms.Button rest_room2_button;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label_temperature_bed_room;
        private System.Windows.Forms.Button bed_room_button;
        private System.Windows.Forms.Button manual0_button;
        private System.Windows.Forms.Button automatic0_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button automatic1_button;
        private System.Windows.Forms.Button manual1_button;
        private System.Windows.Forms.Button manual2_button;
        private System.Windows.Forms.Button automatic2_button;
        private System.Windows.Forms.Button manual3_button;
        private System.Windows.Forms.Button automatic3_button;
        private System.Windows.Forms.Button manual4_button;
        private System.Windows.Forms.Button automatic4_button;
        private System.Windows.Forms.Button manual5_button;
        private System.Windows.Forms.Button automatic5_button;
        private System.Windows.Forms.Button manual6_button;
        private System.Windows.Forms.Button automatic6_button;
        private System.Windows.Forms.PictureBox Mother;
    }
}

