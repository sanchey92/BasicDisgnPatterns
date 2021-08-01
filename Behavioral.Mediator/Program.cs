using Behavioral.Mediator.MediatorWithEvents;

namespace Behavioral.Mediator
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var game = new Game();
            var player = new Player("John", game);
            var coach = new Coach(game);
            
            player.Score();
            player.Score();
            player.Score();
        }
    }
}