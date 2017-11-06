using System;
using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        private Dictionary<int, string> scoreToNameAll = new Dictionary<int, string>()
        {
            { 0,"Love"},
            { 1, "Fifteen"},
            { 2, "Thirty"}
        };

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                m_score1++;
            else
                m_score2++;
        }

        public string GetScore()
        {
            Dictionary<int, string> scoreToName = new Dictionary<int, string>()
        {
            { 0,"Love"},
            { 1, "Fifteen"},
            { 2, "Thirty"},
            { 3, "Forty"}
        };

            if (m_score1 == m_score2)
            {
                return scoreToNameAll.ContainsKey(m_score1) ?
                    $"{scoreToNameAll[m_score1]}-All" : "Deuce";
            }
            if (Math.Max(m_score1, m_score2) >= 4)
            {
                return $"{(Math.Abs(m_score1 - m_score2) == 1 ? "Advantage" : "Win for")}" +
                    $" player{(m_score1 > m_score2 ? "1" : "2")}";
            }
            return $"{scoreToName[m_score1]}-{scoreToName[m_score2]}";
        }
    }
}
