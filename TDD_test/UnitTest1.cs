using Microsoft.VisualStudio.TestTools.UnitTesting;
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
}
