using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.TemplateMethod
{
    /// <summary>
    /// Class representing a game day where a number of sports are played.
    /// Each game day (regardless of the sport) involves taking the field, 
    /// playing, and shaking hands.
    /// </summary>
    public class GameDay
    {
        private List<GameOfSport> _matches;

        public GameDay()
        {
            _matches = new List<GameOfSport>()
                {
                    new GameOfFootball(),
                    new GameOfRugby(),
                    new GameOfCricket()
                };
        }

        public void Commence()
        {
            foreach (var match in _matches)
            {
                PlayMatch(match);
            }
        }

        private void PlayMatch(GameOfSport sportsGame)
        {
            Console.WriteLine(string.Format("Game of {0}:", sportsGame.Name));
            sportsGame.TakeTheField();
            sportsGame.Play();
            sportsGame.ShakeHands();
            Console.WriteLine();
        }
    }
}
