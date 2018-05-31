﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            SecondPlayerGetScoreTimes(2);
            TheScoreShouldBe("Love-Thirty");
        }

        private void SecondPlayerGetScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerGetScore();
            }
        }

        [TestMethod()]
        public void Fifteen_All()
        {
            _tennisGame.FirstPlayerGetScore();
            _tennisGame.SecondPlayerGetScore();
            TheScoreShouldBe("Fifteen-All");
        }

        [TestMethod()]
        public void Thirty_All()
        {
            FirstPlayerGetScoreTimes(2);
            SecondPlayerGetScoreTimes(2);
            TheScoreShouldBe("Thirty-All");
        }

        [TestMethod()]
        public void Deuce_3_3()
        {
            FirstPlayerGetScoreTimes(3);
            SecondPlayerGetScoreTimes(3);
            TheScoreShouldBe("Deuce");
        }

        [TestMethod()]
        public void Deuce_4_4()
        {
            FirstPlayerGetScoreTimes(4);
            SecondPlayerGetScoreTimes(4);
            TheScoreShouldBe("Deuce");
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