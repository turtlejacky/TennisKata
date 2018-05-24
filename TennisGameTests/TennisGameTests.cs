using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame.Tests
{
    [TestClass()]
    public class TennisGameTests
    {
        private TennisGame _tennisGame = new TennisGame("kyo", "vim");

        [TestMethod()]
        public void Fifteen_Love()
        {
            _tennisGame.FirstPlayerGetScore();
            TheScoreShouldBe("Fifteen-Love");
        }

        [TestMethod()]
        public void Forty_Love()
        {
            FirstPlayerGetScoreTimes(3);
            TheScoreShouldBe("Forty-Love");
        }

        [TestMethod()]
        public void Love_All()
        {
            TheScoreShouldBe("Love-All");
        }

        [TestMethod()]
        public void Love_Fifteen()
        {
            _tennisGame.SecondPlayerGetScore();
            TheScoreShouldBe("Love-Fifteen");
        }

        [TestMethod()]
        public void Love_Thirty()
        {
            _tennisGame.SecondPlayerGetScore();
            _tennisGame.SecondPlayerGetScore();
            TheScoreShouldBe("Love-Thirty");
        }

        [TestMethod()]
        public void Thirty_Love()
        {
            FirstPlayerGetScoreTimes(2);
            TheScoreShouldBe("Thirty-Love");
        }

        private void FirstPlayerGetScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerGetScore();
            }
        }

        private void TheScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}