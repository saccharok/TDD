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
}
