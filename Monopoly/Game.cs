namespace Monopoly
{
    public class Game
    {
        private Board _board;
        private Player[] _players;
        public Player CurrentPlayer { get; private set; }

        private static Game _instance = null;

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
        }
        public void Run()
        {
            
        }
    }
}
