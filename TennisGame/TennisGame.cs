using System;
using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGame
    {
        private string _secondPlayerName;
        private string _firstPlayerName;
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        public TennisGame(string firstPlayer, string secondPlayer)
        {
            _firstPlayerName = firstPlayer;
            _secondPlayerName = secondPlayer;
        }

        public string Score()
        {
            return IsScoreDifferent() ? (IsPlayerReadyToWin() ? AdvScore() : NormalScore()) : (IsDeuce() ? Deuce() : SameScore());
        }

        private string SameScore()
        {
            return _scoreLookup[_firstPlayerScoreTimes] + " All";
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3;
        }

        private string NormalScore()
        {
            return _scoreLookup[_firstPlayerScoreTimes] + " " + _scoreLookup[_secondPlayerScoreTimes];
        }

        private string AdvScore()
        {
            return AdvPlayerName() + (IsWin() ? " Win" : " Adv");
        }

        private string AdvPlayerName()
        {
            return (_firstPlayerScoreTimes - _secondPlayerScoreTimes > 0 ? _firstPlayerName : _secondPlayerName);
        }

        private bool IsWin()
        {
            return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) > 1;
        }

        private bool IsPlayerReadyToWin()
        {
            return _firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3;
        }

        private bool IsScoreDifferent()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
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