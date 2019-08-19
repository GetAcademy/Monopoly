using System;

namespace Monopoly
{
    public class Game
    {
        private Board _board;
        private Player[] _players;
        public Player CurrentPlayer { get; private set; }

        private static Game _instance = null;
        private Die _die;

        public static Game Instance => _instance ?? (_instance = new Game());

        private Game()
        {
            _board = new Board();
            _players = new Player[]
            {
                new Player("Per"), 
                new Player("Pål"), 
                new Player("Espen"), 
            };
            _die = new Die();
            GoToNextPlayer();
        }

        private void GoToNextPlayer()
        {
            if (CurrentPlayer == null)
            {
                CurrentPlayer = _players[0];
                return;
            }

            var index = Array.IndexOf(_players, CurrentPlayer);
            index = (index + 1) % _players.Length;
        }

        public void Run()
        {
            while (true)
            {
                var player = Game.Instance.CurrentPlayer;
                Console.WriteLine($"Det er {player.Name} sin tur.");
                Console.WriteLine("Trykk enter for å kaste terningen.");
                var number = _die.Roll();
                Console.WriteLine($"Du kastet {number}.");
                var place = _board.Move(number);



            }
        }
    }
}
