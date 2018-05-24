namespace TennisGame
{
    public class TennisGame
    {
        private string _secondPlayerName;
        private string _firstPlayerName;
        private int _firstPlayerScoreTimes;

        public TennisGame(string firstPlayer, string secondPlayer)
        {
            _firstPlayerName = firstPlayer;
            _secondPlayerName = secondPlayer;
        }

        public string Score()
        {
            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen-Love";
            }
            else if (_firstPlayerScoreTimes == 2)
            {
                return "Thirty-Love";
            }
            else if (_firstPlayerScoreTimes == 3)
            {
                return "Forty-Love";
            }
            return "Love-All";
        }

        public void FirstPlayerGetScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}