namespace Monopoly
{
    public class Game
    {
        private Board _board;
        private Player[] _players;

        public Game()
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
