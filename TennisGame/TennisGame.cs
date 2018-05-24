using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGame
    {
        private string _secondPlayerName;
        private string _firstPlayerName;
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        public TennisGame(string firstPlayer, string secondPlayer)
        {
            _firstPlayerName = firstPlayer;
            _secondPlayerName = secondPlayer;
        }

        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>()
            {
                {0,"Love" },
                {1,"Fifteen" },
                {2,"Thirty" },
                {3,"Forty" },
            };
            if (_firstPlayerScoreTimes != 0)
            {
                return scoreLookup[_firstPlayerScoreTimes] + "-" + "Love";
            }

            if (_secondPlayerScoreTimes == 1)
            {
                return "Love-Fifteen";
            }
            return "Love-All";
        }

        public void FirstPlayerGetScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerGetScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}