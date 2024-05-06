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
}
