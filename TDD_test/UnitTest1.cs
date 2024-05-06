// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com



using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using TDD_game;

namespace TDD_test
{
    [TestClass]
    public class AddGamerButtonTest
    {
        [TestMethod]
        public void AddGamerTest()
        {
            Form1 form1 = new Form1();
            // Arrange
            var gb = new GroupBox();
            var tb = new TextBox();

            // Act
            form1.AddGamer(gb, tb);

            // Assert
            Assert.IsTrue(gb.Visible);
            Assert.IsTrue(tb.Enabled);
        }
    }

    [TestClass]
    public class StartGameButtonTest
    {
        [TestMethod]
        public void StartGameTest()
        {
            Form1 form1 = new Form1();
            // Arrange
            var l1 = new Label();
            var l2 = new Label();
            var l3 = new Label();
            var b1 = new Button();
            var b2 = new Button();
            var b3 = new Button();
            var bs = new Button();
            var c1 = new TextBox();
            var c2 = new TextBox();
            var c3 = new TextBox();

            // Act
            form1.startGame(l1, l2, l3, b1, b2, b3, bs, c1, c2, c3);

            // Assert
            Assert.IsFalse(l1.Visible);
            Assert.IsFalse(l2.Visible);
            Assert.IsFalse(l3.Visible);
            Assert.IsFalse(b1.Visible);
            Assert.IsFalse(b2.Visible);
            Assert.IsFalse(b3.Visible);
            Assert.IsFalse(bs.Visible);
            Assert.IsFalse(c1.Enabled);
            Assert.IsFalse(c2.Enabled);
            Assert.IsFalse(c3.Enabled);
        }
    }

    [TestClass]
    public class SongPlayTest
    {
        [TestMethod]
        public void SongStartTest()
        {
            Form1 form1 = new Form1();
            // Arrange
            var songButton = new Button();
            var gamer1Button = new Button();
            var gamer2Button = new Button();
            var gamer3Button = new Button();
            string path = "C:\\Users\\sonya\\source\\repos\\lr3_testingPO\\lr3_testingPO\\bin\\Debug\\audio\\1.wav"; //C:\Users\sonya\source\repos\lr3_testingPO\lr3_testingPO\bin\Debug\audio
            var player = new SoundPlayer();
            player.SoundLocation = path;

            // Act
            form1.songStart(songButton, gamer1Button, gamer2Button, gamer3Button, path);

            // Assert
            Assert.AreEqual(path, player.SoundLocation);
            Assert.IsTrue(gamer1Button.Enabled);
            Assert.IsTrue(gamer2Button.Enabled);
            Assert.IsTrue(gamer3Button.Enabled);
        }
    }

    [TestClass]
    public class AddPointsTest
    {
        [TestMethod]
        public void AddPointText()
        {
            Form1 form1 = new Form1();
            // Arrange
            string input = "5";
            string expectedOutput = "6";
            var rangeButton = new Button();
            rangeButton.Text = input;

            // Act
            form1.addPoint(rangeButton);

            // Assert
            Assert.AreEqual(rangeButton.Text, expectedOutput);
        }
    }

    [TestClass]
    public class SongDetectedButtonTest
    {
        [TestMethod]
        public void SongDetectedTest()
        {
            Form1 form1 = new Form1();
            // Arrange
            var songButton = new Button();
            var text = "Check";
            Font f = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            // Act
            form1.songDetected(songButton, text);

            // Assert
            Assert.IsFalse(songButton.Enabled);
            Assert.AreEqual(songButton.Text, text);
            Assert.AreEqual(songButton.Font, f);
        }
    }

    [TestClass]
    public class ReturnSongButtonTest
    {
        [TestMethod]
        public void ReturnSong1()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 1;
            var VaitingButton = form1.song1;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong2()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 2;
            var VaitingButton = form1.song2;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong3()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 3;
            var VaitingButton = form1.song3;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong4()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 4;
            var VaitingButton = form1.song4;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong5()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 5;
            var VaitingButton = form1.song5;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong6()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 6;
            var VaitingButton = form1.song6;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong7()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 7;
            var VaitingButton = form1.song7;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong8()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 8;
            var VaitingButton = form1.song8;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong9()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 9;
            var VaitingButton = form1.song9;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong10()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 10;
            var VaitingButton = form1.song10;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong11()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 11;
            var VaitingButton = form1.song11;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong12()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 12;
            var VaitingButton = form1.song12;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong13()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 13;
            var VaitingButton = form1.song13;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong14()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 14;
            var VaitingButton = form1.song14;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong15()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 15;
            var VaitingButton = form1.song15;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong16()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 16;
            var VaitingButton = form1.song16;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong17()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 17;
            var VaitingButton = form1.song17;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong18()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 18;
            var VaitingButton = form1.song18;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong19()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 19;
            var VaitingButton = form1.song19;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }

        [TestMethod]
        public void ReturnSong20()
        {
            Form1 form1 = new Form1();
            // Arrange
            int value = 20;
            var VaitingButton = form1.song20;
            var testButton = new Button();

            // Act
            testButton = form1.returnSongButton(value);

            // Assert
            Assert.AreEqual(testButton, VaitingButton);
        }
    }

    [TestClass]
    public class ReturnSongNameTest
    {
        [TestMethod]
        public void returnName1()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "The Hatters - Просто проваливай";
            int num = 1;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName2()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "5sta Family - Моя мелодия";
            int num = 2;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName3()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Eminem - The Real Slim Shady";
            int num = 3;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName4()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "МУККА - Мертвые цветы";
            int num = 4;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName5()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Muse - Butterfies And Hurricanes";
            int num = 5;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName6()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "TRITIA, Асия - Жить тобой";
            int num = 6;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName7()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "One Direction - What Makes You Beautiful";
            int num = 7;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName8()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Palina - Я пойму";
            int num = 8;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName9()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Rob Zombie - Dragula";
            int num = 9;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName10()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Бумбокс - Та4то";
            int num = 10;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName11()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Джинсы Тарковского - Атлантида";
            int num = 11;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName12()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Градусы - Запишу свое сердце на секцию плавания";
            int num = 12;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName13()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Дора - Младшая сестра";
            int num = 13;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName14()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Жанна Фриске - Ла-ла-ла";
            int num = 14;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName15()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Комната Культуры - Поезда";
            int num = 15;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName16()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Максим Свобода - Дурак";
            int num = 16;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName17()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "просто Лера - Инопланетяне";
            int num = 17;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName18()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Юлия Савичева - Как твои дела";
            int num = 18;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName19()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "Сметана Band - Каждый твой";
            int num = 19;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }

        [TestMethod]
        public void returnName20()
        {
            Form1 form1 = new Form1();
            // Arrange
            string value = "СЛАВА, Стас Пьеха - Я и Ты";
            int num = 20;
            string testValue;

            // Act
            testValue = form1.returnSongName(num);

            // Assert
            Assert.AreEqual(value, testValue);
        }
    }
}
