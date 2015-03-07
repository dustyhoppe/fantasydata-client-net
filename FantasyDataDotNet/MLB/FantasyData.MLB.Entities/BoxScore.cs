namespace FantasyData.MLB.Entities
{
    using System.Collections.Generic;

    public class BoxScores : List<BoxScore>
    { }

    public class BoxScore
    {
        public BoxScore()
        {
            Game = new Game();
            Innings = new Innings();
            PlayerGames = new PlayerGames();
            TeamGames = new TeamGames();
        }

        public Game Game { get; set; }
        public Innings Innings { get; set; }
        public PlayerGames PlayerGames { get; set; }
        public TeamGames TeamGames { get; set; }
    }
}
