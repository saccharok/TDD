﻿// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD_game
{
    public partial class Form1 : Form
    {
        private string songPath;
        private int number;
        private SoundPlayer player;
        public Form1()
        {
            InitializeComponent();
            gamerBox1.Visible = false;
            gamerBox2.Visible = false;
            gamerBox3.Visible = false;
            song1.Visible = false;
            song2.Visible = false;
            song3.Visible = false;
            song4.Visible = false;
            song5.Visible = false;
            song6.Visible = false;
            song7.Visible = false;
            song8.Visible = false;
            song9.Visible = false;
            song10.Visible = false;
            song11.Visible = false;
            song12.Visible = false;
            song13.Visible = false;
            song14.Visible = false;
            song15.Visible = false;
            song16.Visible = false;
            song17.Visible = false;
            song18.Visible = false;
            song19.Visible = false;
            song20.Visible = false;
            range1.Enabled = false;
            range2.Enabled = false;
            range3.Enabled = false;
        }

        public void AddGamer(GroupBox gb, TextBox tb)
        {
            gb.Visible = true;
            tb.Enabled = true;
        }

        private void addGamer1_Click(object sender, EventArgs e)
        {
            AddGamer(gamerBox1, gamerName1);
        }

        private void addGamer2_Click(object sender, EventArgs e)
        {
            AddGamer(gamerBox2, gamerName2);
        }

        private void addGamer3_Click(object sender, EventArgs e)
        {
            AddGamer(gamerBox3, gamerName3);
        }

        public void startGame(Label l1, Label l2, Label l3, Button b1, Button b2, Button b3, Button start, TextBox c1, TextBox c2, TextBox c3)
        {
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            start.Visible = false;
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            song1.Visible = true;
            song2.Visible = true;
            song3.Visible = true;
            song4.Visible = true;
            song5.Visible = true;
            song6.Visible = true;
            song7.Visible = true;
            song8.Visible = true;
            song9.Visible = true;
            song10.Visible = true;
            song11.Visible = true;
            song12.Visible = true;
            song13.Visible = true;
            song14.Visible = true;
            song15.Visible = true;
            song16.Visible = true;
            song17.Visible = true;
            song18.Visible = true;
            song19.Visible = true;
            song20.Visible = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startGame(labelName1, labelName2, labelName3, addGamer1, addGamer2, addGamer3, startButton, gamerName1, gamerName2, gamerName3);
        }

        public void songStart(Button song, Button gamer1, Button gamer2, Button gamer3, string path)
        {
            player = new SoundPlayer();
            player.SoundLocation = path;
            player.Play();
            gamer1.Enabled = true;
            gamer2.Enabled = true;
            gamer3.Enabled = true;
        }

        private void song1_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\1.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 1;
        }

        private void song2_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\2.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 2;
        }

        private void song3_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\3.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 3;
        }

        private void song4_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\4.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 4;
        }

        private void song5_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\5.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 5;
        }

        private void song6_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\6.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 6;
        }

        private void song7_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\7.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 7;
        }

        private void song8_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\8.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 8;
        }

        private void song9_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\9.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 9;
        }

        private void song10_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\10.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 10;
        }

        private void song11_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\11.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 11;
        }

        private void song12_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\12.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 12;
        }

        private void song13_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\13.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 13;
        }

        private void song14_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\14.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 14;
        }

        private void song15_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\15.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 15;
        }

        private void song16_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\16.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 16;
        }

        private void song17_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\17.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 17;
        }

        private void song18_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\18.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 18;
        }

        private void song19_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\19.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 19;
        }

        private void song20_Click(object sender, EventArgs e)
        {
            songPath = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\20.wav";
            songStart(song1, range1, range2, range3, songPath);
            number = 20;
        }
        
        public void addPoint(Button gamerRange)
        {
            int tmp = Convert.ToInt32(gamerRange.Text);
            tmp += 1;
            gamerRange.Text = tmp.ToString();
        }

        public void songDetected(Button song, string text)
        {
            song.Text = text;
            song.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            song.Enabled = false;
        }

        public Button returnSongButton(int number)
        {
            if (number == 1)
                return song1;
            else if (number == 2)
                return song2;
            else if (number == 3)
                return song3;
            else if (number == 4)
                return song4;
            else if (number == 5)
                return song5;
            else if (number == 6)
                return song6;
            else if (number == 7)
                return song7;
            else if (number == 8)
                return song8;
            else if (number == 9)
                return song9;
            else if (number == 10)
                return song10;
            else if (number == 11)
                return song11;
            else if (number == 12)
                return song12;
            else if (number == 13)
                return song13;
            else if (number == 14)
                return song14;
            else if (number == 15)
                return song15;
            else if (number == 16)
                return song16;
            else if (number == 17)
                return song17;
            else if (number == 18)
                return song18;
            else if (number == 19)
                return song19;
            else return song20;
        }

        public string returnSongName(int number)
        {
            if (number == 1)
                return "The Hatters - Просто проваливай";
            else if (number == 2)
                return "5sta Family - Моя мелодия";
            else if (number == 3)
                return "Eminem - The Real Slim Shady";
            else if (number == 4)
                return "МУККА - Мертвые цветы";
            else if (number == 5)
                return "Muse - Butterfies And Hurricanes";
            else if (number == 6)
                return "TRITIA, Асия - Жить тобой";
            else if (number == 7)
                return "One Direction - What Makes You Beautiful";
            else if (number == 8)
                return "Palina - Я пойму";
            else if (number == 9)
                return "Rob Zombie - Dragula";
            else if (number == 10)
                return "Бумбокс - Та4то";
            else if (number == 11)
                return "Джинсы Тарковского - Атлантида";
            else if (number == 12)
                return "Градусы - Запишу свое сердце на секцию плавания";
            else if (number == 13)
                return "Дора - Младшая сестра";
            else if (number == 14)
                return "Жанна Фриске - Ла-ла-ла";
            else if (number == 15)
                return "Комната Культуры - Поезда";
            else if (number == 16)
                return "Максим Свобода - Дурак";
            else if (number == 17)
                return "просто Лера - Инопланетяне";
            else if (number == 18)
                return "Юлия Савичева - Как твои дела";
            else if (number == 19)
                return "Сметана Band - Каждый твой";
            else return "СЛАВА, Стас Пьеха - Я и Ты";
        }

        private void range1_Click_1(object sender, EventArgs e)
        {
            addPoint(range1);
            Button song = returnSongButton(number);
            songDetected(song, returnSongName(number));
            range1.Enabled = false;
            range2.Enabled = false;
            range3.Enabled = false;
            player.Stop();
        }

        private void range2_Click_1(object sender, EventArgs e)
        {
            addPoint(range2);
            Button song = returnSongButton(number);
            songDetected(song, returnSongName(number));
            range1.Enabled = false;
            range2.Enabled = false;
            range3.Enabled = false;
            player.Stop();
        }

        private void range3_Click_1(object sender, EventArgs e)
        {
            addPoint(range3);
            Button song = returnSongButton(number);
            songDetected(song, returnSongName(number));
            range1.Enabled = false;
            range2.Enabled = false;
            range3.Enabled = false;
            player.Stop();
        }
    }
}
