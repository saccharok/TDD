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


    }
}
