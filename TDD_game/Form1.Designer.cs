namespace TDD_game
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
            this.startButton = new System.Windows.Forms.Button();
            this.addGamer3 = new System.Windows.Forms.Button();
            this.addGamer2 = new System.Windows.Forms.Button();
            this.addGamer1 = new System.Windows.Forms.Button();
            this.gamerBox2 = new System.Windows.Forms.GroupBox();
            this.range2 = new System.Windows.Forms.Button();
            this.gamerRating2 = new System.Windows.Forms.Label();
            this.gamerName2 = new System.Windows.Forms.TextBox();
            this.labelName2 = new System.Windows.Forms.Label();
            this.gamerBox3 = new System.Windows.Forms.GroupBox();
            this.range3 = new System.Windows.Forms.Button();
            this.gamerRating3 = new System.Windows.Forms.Label();
            this.gamerName3 = new System.Windows.Forms.TextBox();
            this.labelName3 = new System.Windows.Forms.Label();
            this.gamerBox1 = new System.Windows.Forms.GroupBox();
            this.range1 = new System.Windows.Forms.Button();
            this.gamerRating1 = new System.Windows.Forms.Label();
            this.gamerName1 = new System.Windows.Forms.TextBox();
            this.labelName1 = new System.Windows.Forms.Label();
            this.song5 = new System.Windows.Forms.Button();
            this.song4 = new System.Windows.Forms.Button();
            this.song3 = new System.Windows.Forms.Button();
            this.song2 = new System.Windows.Forms.Button();
            this.song1 = new System.Windows.Forms.Button();
            this.song10 = new System.Windows.Forms.Button();
            this.song9 = new System.Windows.Forms.Button();
            this.song8 = new System.Windows.Forms.Button();
            this.song7 = new System.Windows.Forms.Button();
            this.song6 = new System.Windows.Forms.Button();
            this.song15 = new System.Windows.Forms.Button();
            this.song14 = new System.Windows.Forms.Button();
            this.song13 = new System.Windows.Forms.Button();
            this.song12 = new System.Windows.Forms.Button();
            this.song11 = new System.Windows.Forms.Button();
            this.song20 = new System.Windows.Forms.Button();
            this.song19 = new System.Windows.Forms.Button();
            this.song18 = new System.Windows.Forms.Button();
            this.song17 = new System.Windows.Forms.Button();
            this.song16 = new System.Windows.Forms.Button();
            this.gamerBox2.SuspendLayout();
            this.gamerBox3.SuspendLayout();
            this.gamerBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(293, 202);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(267, 36);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "НАЧАТЬ ИГРУ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // addGamer3
            // 
            this.addGamer3.Location = new System.Drawing.Point(566, 118);
            this.addGamer3.Name = "addGamer3";
            this.addGamer3.Size = new System.Drawing.Size(277, 36);
            this.addGamer3.TabIndex = 13;
            this.addGamer3.Text = "Добавить игрока";
            this.addGamer3.UseVisualStyleBackColor = true;
            this.addGamer3.Click += new System.EventHandler(this.addGamer3_Click);
            // 
            // addGamer2
            // 
            this.addGamer2.Location = new System.Drawing.Point(293, 118);
            this.addGamer2.Name = "addGamer2";
            this.addGamer2.Size = new System.Drawing.Size(267, 36);
            this.addGamer2.TabIndex = 12;
            this.addGamer2.Text = "Добавить игрока";
            this.addGamer2.UseVisualStyleBackColor = true;
            this.addGamer2.Click += new System.EventHandler(this.addGamer2_Click);
            // 
            // addGamer1
            // 
            this.addGamer1.Location = new System.Drawing.Point(10, 118);
            this.addGamer1.Name = "addGamer1";
            this.addGamer1.Size = new System.Drawing.Size(277, 36);
            this.addGamer1.TabIndex = 11;
            this.addGamer1.Text = "Добавить игрока";
            this.addGamer1.UseVisualStyleBackColor = true;
            this.addGamer1.Click += new System.EventHandler(this.addGamer1_Click);
            // 
            // gamerBox2
            // 
            this.gamerBox2.Controls.Add(this.range2);
            this.gamerBox2.Controls.Add(this.gamerRating2);
            this.gamerBox2.Controls.Add(this.gamerName2);
            this.gamerBox2.Controls.Add(this.labelName2);
            this.gamerBox2.Location = new System.Drawing.Point(293, 12);
            this.gamerBox2.Name = "gamerBox2";
            this.gamerBox2.Size = new System.Drawing.Size(267, 100);
            this.gamerBox2.TabIndex = 10;
            this.gamerBox2.TabStop = false;
            // 
            // range2
            // 
            this.range2.Location = new System.Drawing.Point(85, 61);
            this.range2.Name = "range2";
            this.range2.Size = new System.Drawing.Size(100, 23);
            this.range2.TabIndex = 9;
            this.range2.Text = "0";
            this.range2.UseVisualStyleBackColor = true;
            // 
            // gamerRating2
            // 
            this.gamerRating2.AutoSize = true;
            this.gamerRating2.Location = new System.Drawing.Point(8, 61);
            this.gamerRating2.Name = "gamerRating2";
            this.gamerRating2.Size = new System.Drawing.Size(52, 16);
            this.gamerRating2.TabIndex = 8;
            this.gamerRating2.Text = "Баллы:";
            // 
            // gamerName2
            // 
            this.gamerName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamerName2.Location = new System.Drawing.Point(85, 17);
            this.gamerName2.Name = "gamerName2";
            this.gamerName2.Size = new System.Drawing.Size(100, 22);
            this.gamerName2.TabIndex = 7;
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName2.Location = new System.Drawing.Point(6, 18);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(54, 18);
            this.labelName2.TabIndex = 7;
            this.labelName2.Text = "Игрок:";
            // 
            // gamerBox3
            // 
            this.gamerBox3.Controls.Add(this.range3);
            this.gamerBox3.Controls.Add(this.gamerRating3);
            this.gamerBox3.Controls.Add(this.gamerName3);
            this.gamerBox3.Controls.Add(this.labelName3);
            this.gamerBox3.Location = new System.Drawing.Point(566, 12);
            this.gamerBox3.Name = "gamerBox3";
            this.gamerBox3.Size = new System.Drawing.Size(277, 100);
            this.gamerBox3.TabIndex = 9;
            this.gamerBox3.TabStop = false;
            // 
            // range3
            // 
            this.range3.Location = new System.Drawing.Point(97, 58);
            this.range3.Name = "range3";
            this.range3.Size = new System.Drawing.Size(100, 23);
            this.range3.TabIndex = 10;
            this.range3.Text = "0";
            this.range3.UseVisualStyleBackColor = true;
            // 
            // gamerRating3
            // 
            this.gamerRating3.AutoSize = true;
            this.gamerRating3.Location = new System.Drawing.Point(6, 61);
            this.gamerRating3.Name = "gamerRating3";
            this.gamerRating3.Size = new System.Drawing.Size(52, 16);
            this.gamerRating3.TabIndex = 9;
            this.gamerRating3.Text = "Баллы:";
            // 
            // gamerName3
            // 
            this.gamerName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamerName3.Location = new System.Drawing.Point(97, 17);
            this.gamerName3.Name = "gamerName3";
            this.gamerName3.Size = new System.Drawing.Size(100, 22);
            this.gamerName3.TabIndex = 8;
            // 
            // labelName3
            // 
            this.labelName3.AutoSize = true;
            this.labelName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName3.Location = new System.Drawing.Point(6, 18);
            this.labelName3.Name = "labelName3";
            this.labelName3.Size = new System.Drawing.Size(54, 18);
            this.labelName3.TabIndex = 8;
            this.labelName3.Text = "Игрок:";
            // 
            // gamerBox1
            // 
            this.gamerBox1.Controls.Add(this.range1);
            this.gamerBox1.Controls.Add(this.gamerRating1);
            this.gamerBox1.Controls.Add(this.gamerName1);
            this.gamerBox1.Controls.Add(this.labelName1);
            this.gamerBox1.Location = new System.Drawing.Point(10, 12);
            this.gamerBox1.Name = "gamerBox1";
            this.gamerBox1.Size = new System.Drawing.Size(277, 100);
            this.gamerBox1.TabIndex = 8;
            this.gamerBox1.TabStop = false;
            // 
            // range1
            // 
            this.range1.Location = new System.Drawing.Point(91, 61);
            this.range1.Name = "range1";
            this.range1.Size = new System.Drawing.Size(100, 23);
            this.range1.TabIndex = 8;
            this.range1.Text = "0";
            this.range1.UseVisualStyleBackColor = true;
            // 
            // gamerRating1
            // 
            this.gamerRating1.AutoSize = true;
            this.gamerRating1.Location = new System.Drawing.Point(9, 61);
            this.gamerRating1.Name = "gamerRating1";
            this.gamerRating1.Size = new System.Drawing.Size(52, 16);
            this.gamerRating1.TabIndex = 7;
            this.gamerRating1.Text = "Баллы:";
            // 
            // gamerName1
            // 
            this.gamerName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamerName1.Location = new System.Drawing.Point(91, 17);
            this.gamerName1.Name = "gamerName1";
            this.gamerName1.Size = new System.Drawing.Size(100, 22);
            this.gamerName1.TabIndex = 6;
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName1.Location = new System.Drawing.Point(6, 18);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(54, 18);
            this.labelName1.TabIndex = 6;
            this.labelName1.Text = "Игрок:";
            // 
            // song5
            // 
            this.song5.Font = new System.Drawing.Font("Soledago", 36F);
            this.song5.Location = new System.Drawing.Point(704, 160);
            this.song5.Name = "song5";
            this.song5.Size = new System.Drawing.Size(142, 165);
            this.song5.TabIndex = 47;
            this.song5.Text = "5";
            this.song5.UseVisualStyleBackColor = true;
            this.song5.Click += new System.EventHandler(this.song5_Click);
            // 
            // song4
            // 
            this.song4.Font = new System.Drawing.Font("Soledago", 36F);
            this.song4.Location = new System.Drawing.Point(533, 160);
            this.song4.Name = "song4";
            this.song4.Size = new System.Drawing.Size(142, 165);
            this.song4.TabIndex = 46;
            this.song4.Text = "4";
            this.song4.UseVisualStyleBackColor = true;
            this.song4.Click += new System.EventHandler(this.song4_Click);
            // 
            // song3
            // 
            this.song3.Font = new System.Drawing.Font("Soledago", 36F);
            this.song3.Location = new System.Drawing.Point(362, 160);
            this.song3.Name = "song3";
            this.song3.Size = new System.Drawing.Size(142, 165);
            this.song3.TabIndex = 45;
            this.song3.Text = "3";
            this.song3.UseVisualStyleBackColor = true;
            this.song3.Click += new System.EventHandler(this.song3_Click);
            // 
            // song2
            // 
            this.song2.Font = new System.Drawing.Font("Soledago", 36F);
            this.song2.Location = new System.Drawing.Point(191, 160);
            this.song2.Name = "song2";
            this.song2.Size = new System.Drawing.Size(142, 165);
            this.song2.TabIndex = 44;
            this.song2.Text = "2";
            this.song2.UseVisualStyleBackColor = true;
            this.song2.Click += new System.EventHandler(this.song2_Click);
            // 
            // song1
            // 
            this.song1.Font = new System.Drawing.Font("Soledago", 36F);
            this.song1.Location = new System.Drawing.Point(13, 160);
            this.song1.Name = "song1";
            this.song1.Size = new System.Drawing.Size(142, 165);
            this.song1.TabIndex = 43;
            this.song1.Text = "1";
            this.song1.UseVisualStyleBackColor = true;
            this.song1.Click += new System.EventHandler(this.song1_Click);
            // 
            // song10
            // 
            this.song10.Font = new System.Drawing.Font("Soledago", 36F);
            this.song10.Location = new System.Drawing.Point(704, 331);
            this.song10.Name = "song10";
            this.song10.Size = new System.Drawing.Size(142, 165);
            this.song10.TabIndex = 42;
            this.song10.Text = "10";
            this.song10.UseVisualStyleBackColor = true;
            this.song10.Click += new System.EventHandler(this.song10_Click);
            // 
            // song9
            // 
            this.song9.Font = new System.Drawing.Font("Soledago", 36F);
            this.song9.Location = new System.Drawing.Point(533, 331);
            this.song9.Name = "song9";
            this.song9.Size = new System.Drawing.Size(142, 165);
            this.song9.TabIndex = 41;
            this.song9.Text = "9";
            this.song9.UseVisualStyleBackColor = true;
            this.song9.Click += new System.EventHandler(this.song9_Click);
            // 
            // song8
            // 
            this.song8.Font = new System.Drawing.Font("Soledago", 36F);
            this.song8.Location = new System.Drawing.Point(362, 331);
            this.song8.Name = "song8";
            this.song8.Size = new System.Drawing.Size(142, 165);
            this.song8.TabIndex = 40;
            this.song8.Text = "8";
            this.song8.UseVisualStyleBackColor = true;
            this.song8.Click += new System.EventHandler(this.song8_Click);
            // 
            // song7
            // 
            this.song7.Font = new System.Drawing.Font("Soledago", 36F);
            this.song7.Location = new System.Drawing.Point(191, 331);
            this.song7.Name = "song7";
            this.song7.Size = new System.Drawing.Size(142, 165);
            this.song7.TabIndex = 39;
            this.song7.Text = "7";
            this.song7.UseVisualStyleBackColor = true;
            this.song7.Click += new System.EventHandler(this.song7_Click);
            // 
            // song6
            // 
            this.song6.Font = new System.Drawing.Font("Soledago", 36F);
            this.song6.Location = new System.Drawing.Point(13, 331);
            this.song6.Name = "song6";
            this.song6.Size = new System.Drawing.Size(142, 165);
            this.song6.TabIndex = 38;
            this.song6.Text = "6";
            this.song6.UseVisualStyleBackColor = true;
            this.song6.Click += new System.EventHandler(this.song6_Click);
            // 
            // song15
            // 
            this.song15.Font = new System.Drawing.Font("Soledago", 36F);
            this.song15.Location = new System.Drawing.Point(704, 502);
            this.song15.Name = "song15";
            this.song15.Size = new System.Drawing.Size(142, 165);
            this.song15.TabIndex = 37;
            this.song15.Text = "15";
            this.song15.UseVisualStyleBackColor = true;
            this.song15.Click += new System.EventHandler(this.song15_Click);
            // 
            // song14
            // 
            this.song14.Font = new System.Drawing.Font("Soledago", 36F);
            this.song14.Location = new System.Drawing.Point(533, 502);
            this.song14.Name = "song14";
            this.song14.Size = new System.Drawing.Size(142, 165);
            this.song14.TabIndex = 36;
            this.song14.Text = "14";
            this.song14.UseVisualStyleBackColor = true;
            this.song14.Click += new System.EventHandler(this.song14_Click);
            // 
            // song13
            // 
            this.song13.Font = new System.Drawing.Font("Soledago", 36F);
            this.song13.Location = new System.Drawing.Point(362, 502);
            this.song13.Name = "song13";
            this.song13.Size = new System.Drawing.Size(142, 165);
            this.song13.TabIndex = 35;
            this.song13.Text = "13";
            this.song13.UseVisualStyleBackColor = true;
            this.song13.Click += new System.EventHandler(this.song13_Click);
            // 
            // song12
            // 
            this.song12.Font = new System.Drawing.Font("Soledago", 36F);
            this.song12.Location = new System.Drawing.Point(191, 502);
            this.song12.Name = "song12";
            this.song12.Size = new System.Drawing.Size(142, 165);
            this.song12.TabIndex = 34;
            this.song12.Text = "12";
            this.song12.UseVisualStyleBackColor = true;
            this.song12.Click += new System.EventHandler(this.song12_Click);
            // 
            // song11
            // 
            this.song11.Font = new System.Drawing.Font("Soledago", 36F);
            this.song11.Location = new System.Drawing.Point(13, 502);
            this.song11.Name = "song11";
            this.song11.Size = new System.Drawing.Size(142, 165);
            this.song11.TabIndex = 33;
            this.song11.Text = "11";
            this.song11.UseVisualStyleBackColor = true;
            this.song11.Click += new System.EventHandler(this.song11_Click);
            // 
            // song20
            // 
            this.song20.Font = new System.Drawing.Font("Soledago", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.song20.Location = new System.Drawing.Point(704, 673);
            this.song20.Name = "song20";
            this.song20.Size = new System.Drawing.Size(142, 165);
            this.song20.TabIndex = 32;
            this.song20.Text = "20";
            this.song20.UseVisualStyleBackColor = true;
            this.song20.Click += new System.EventHandler(this.song20_Click);
            // 
            // song19
            // 
            this.song19.Font = new System.Drawing.Font("Soledago", 36F);
            this.song19.Location = new System.Drawing.Point(533, 673);
            this.song19.Name = "song19";
            this.song19.Size = new System.Drawing.Size(142, 165);
            this.song19.TabIndex = 31;
            this.song19.Text = "19";
            this.song19.UseVisualStyleBackColor = true;
            this.song19.Click += new System.EventHandler(this.song19_Click);
            // 
            // song18
            // 
            this.song18.Font = new System.Drawing.Font("Soledago", 36F);
            this.song18.Location = new System.Drawing.Point(362, 673);
            this.song18.Name = "song18";
            this.song18.Size = new System.Drawing.Size(142, 165);
            this.song18.TabIndex = 30;
            this.song18.Text = "18";
            this.song18.UseVisualStyleBackColor = true;
            this.song18.Click += new System.EventHandler(this.song18_Click);
            // 
            // song17
            // 
            this.song17.Font = new System.Drawing.Font("Soledago", 36F);
            this.song17.Location = new System.Drawing.Point(191, 673);
            this.song17.Name = "song17";
            this.song17.Size = new System.Drawing.Size(142, 165);
            this.song17.TabIndex = 29;
            this.song17.Text = "17";
            this.song17.UseVisualStyleBackColor = true;
            this.song17.Click += new System.EventHandler(this.song17_Click);
            // 
            // song16
            // 
            this.song16.Font = new System.Drawing.Font("Soledago", 36F);
            this.song16.Location = new System.Drawing.Point(13, 673);
            this.song16.Name = "song16";
            this.song16.Size = new System.Drawing.Size(142, 165);
            this.song16.TabIndex = 28;
            this.song16.Text = "16";
            this.song16.UseVisualStyleBackColor = true;
            this.song16.Click += new System.EventHandler(this.song16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 844);
            this.Controls.Add(this.song5);
            this.Controls.Add(this.song4);
            this.Controls.Add(this.song3);
            this.Controls.Add(this.song2);
            this.Controls.Add(this.song1);
            this.Controls.Add(this.song10);
            this.Controls.Add(this.song9);
            this.Controls.Add(this.song8);
            this.Controls.Add(this.song7);
            this.Controls.Add(this.song6);
            this.Controls.Add(this.song15);
            this.Controls.Add(this.song14);
            this.Controls.Add(this.song13);
            this.Controls.Add(this.song12);
            this.Controls.Add(this.song11);
            this.Controls.Add(this.song20);
            this.Controls.Add(this.song19);
            this.Controls.Add(this.song18);
            this.Controls.Add(this.song17);
            this.Controls.Add(this.song16);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.addGamer3);
            this.Controls.Add(this.addGamer2);
            this.Controls.Add(this.addGamer1);
            this.Controls.Add(this.gamerBox2);
            this.Controls.Add(this.gamerBox3);
            this.Controls.Add(this.gamerBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gamerBox2.ResumeLayout(false);
            this.gamerBox2.PerformLayout();
            this.gamerBox3.ResumeLayout(false);
            this.gamerBox3.PerformLayout();
            this.gamerBox1.ResumeLayout(false);
            this.gamerBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button addGamer3;
        private System.Windows.Forms.Button addGamer2;
        private System.Windows.Forms.Button addGamer1;
        private System.Windows.Forms.GroupBox gamerBox2;
        private System.Windows.Forms.Button range2;
        private System.Windows.Forms.Label gamerRating2;
        private System.Windows.Forms.TextBox gamerName2;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.GroupBox gamerBox3;
        private System.Windows.Forms.Button range3;
        private System.Windows.Forms.Label gamerRating3;
        private System.Windows.Forms.TextBox gamerName3;
        private System.Windows.Forms.Label labelName3;
        private System.Windows.Forms.GroupBox gamerBox1;
        private System.Windows.Forms.Button range1;
        private System.Windows.Forms.Label gamerRating1;
        private System.Windows.Forms.TextBox gamerName1;
        private System.Windows.Forms.Label labelName1;
        public System.Windows.Forms.Button song5;
        public System.Windows.Forms.Button song4;
        public System.Windows.Forms.Button song3;
        public System.Windows.Forms.Button song2;
        public System.Windows.Forms.Button song1;
        public System.Windows.Forms.Button song10;
        public System.Windows.Forms.Button song9;
        public System.Windows.Forms.Button song8;
        public System.Windows.Forms.Button song7;
        public System.Windows.Forms.Button song6;
        public System.Windows.Forms.Button song15;
        public System.Windows.Forms.Button song14;
        public System.Windows.Forms.Button song13;
        public System.Windows.Forms.Button song12;
        public System.Windows.Forms.Button song11;
        public System.Windows.Forms.Button song20;
        public System.Windows.Forms.Button song19;
        public System.Windows.Forms.Button song18;
        public System.Windows.Forms.Button song17;
        public System.Windows.Forms.Button song16;
    }
}

