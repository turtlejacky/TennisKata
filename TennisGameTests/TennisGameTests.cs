using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame.Tests
{
    [TestClass()]
    public class TennisGameTests
    {
        private TennisGame _tennisGame = new TennisGame("kyo", "vim");

        [TestMethod()]
        public void Love_All()
        {
            TheScoreShouldBe("Love-All");
        }

        [TestMethod()]
        public void Fifteen_Love()
        {
            _tennisGame.FirstPlayerGetScore();
            TheScoreShouldBe("Fifteen-Love");
        }

        [TestMethod()]
        public void Thirty_Love()
        {
            _tennisGame.FirstPlayerGetScore();
            _tennisGame.FirstPlayerGetScore();
            TheScoreShouldBe("Thirty-Love");
        }

        [TestMethod()]
        public void Forty_Love()
        {
            _tennisGame.FirstPlayerGetScore();
            _tennisGame.FirstPlayerGetScore();
            _tennisGame.FirstPlayerGetScore();
            TheScoreShouldBe("Forty-Love");
        }

        private void TheScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}