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

            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes)
            {
                return scoreLookup[_firstPlayerScoreTimes] + "-" + scoreLookup[_secondPlayerScoreTimes];
            }
            else
            {
                if (_firstPlayerScoreTimes >= 3)
                {
                    return "Deuce";
                }
                return scoreLookup[_firstPlayerScoreTimes] + "-All";
            }
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