namespace FantasyData.NFL.Entities
{
  using System.Collections.Generic;

  public class BoxScores : List<BoxScore>
  { }

  public class BoxScore
  {
    public BoxScore()
    {
      AwayDefense = new PlayerDefenses();
      AwayFantasyDefense = new FantasyDefenseGames();
      AwayKickPuntReturns = new KickPuntReturns();
      AwayKicking = new PlayerKickings();
      AwayPassing = new PlayerPassings();
      AwayPunting = new PlayerPuntings();
      AwayReceiving = new PlayerReceivings();
      AwayRushing = new PlayerRushings();


      HomeDefense = new PlayerDefenses();
      HomeFantasyDefense = new FantasyDefenseGames();
      HomeKickPuntReturns = new KickPuntReturns();
      HomeKicking = new PlayerKickings();
      HomePassing = new PlayerPassings();
      HomePunting = new PlayerPuntings();
      HomeReceiving = new PlayerReceivings();
      HomeRushing = new PlayerRushings();

      //Game = new Game();
      ScoringDetails = new ScoringDetails();
      ScoringPlays = new ScoringPlays();
    }

    public PlayerDefenses AwayDefense { get; set; }
    public FantasyDefenseGames AwayFantasyDefense { get; set; }
    public KickPuntReturns AwayKickPuntReturns { get; set; }
    public PlayerKickings AwayKicking { get; set; }
    public PlayerPassings AwayPassing { get; set; }
    public PlayerPuntings AwayPunting { get; set; }
    public PlayerReceivings AwayReceiving { get; set; }
    public PlayerRushings AwayRushing { get; set; }


    public PlayerDefenses HomeDefense { get; set; }
    public FantasyDefenseGames HomeFantasyDefense { get; set; }
    public KickPuntReturns HomeKickPuntReturns { get; set; }
    public PlayerKickings HomeKicking { get; set; }
    public PlayerPassings HomePassing { get; set; }
    public PlayerPuntings HomePunting { get; set; }
    public PlayerReceivings HomeReceiving { get; set; }
    public PlayerRushings HomeRushing { get; set; }

    // Bug: Deserialization of this property causes deserialization of entire object to break.
    //public Game Game { get; set; }
    public ScoringDetails ScoringDetails { get; set; }
    public ScoringPlays ScoringPlays { get; set; }
  }
}
