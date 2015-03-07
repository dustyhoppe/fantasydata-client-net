using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class Players : List<Player>
  { }

  public class Player
  {
    public Player()
    {
      LatestNews = new News();
      InjuryStatus = new Injury();
      PlayerSeason = new PlayerSeason();
    }

    public bool Active { get; set; }
    public int Age { get; set; }
    public decimal AverageDraftPosition { get; set; }
    public DateTime BirthDate { get; set; }
    public string BirthDateString { get; set; }
    public int ByeWeek { get; set; }
    public string College { get; set; }
    public int CollegeDraftPick { get; set; }
    public int CollegeDraftRound { get; set; }
    public string CollegeDraftTeam { get; set; }
    public int CollegeDraftYear { get; set; }
    public string CurrentStatus { get; set; }
    public string CurrentTeam { get; set; }
    public int DepthDisplayOrder { get; set; }
    public int DepthOrder { get; set; }
    public string DepthPosition { get; set; }
    public int DepthPositionCategory { get; set; }
    public int Experience { get; set; }
    public string ExperienceString { get; set; }
    public string FantasyPosition { get; set; }
    public string FirstName { get; set; }
    public string Height { get; set; }
    public int HeightFeet { get; set; }
    public int HeightInches { get; set; }
    public bool IsUndraftedFreeAgent { get; set; }
    public string LastName { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public string PhotoUrl { get; set; }
    public int PlayerID { get; set; }
    public string Position { get; set; }
    public string PositionCategory { get; set; }
    public string ShortName { get; set; }
    public string Status { get; set; }
    public string Team { get; set; }
    public string UpcomingGameOpponent { get; set; }
    public int UpcomingGameWeek { get; set; }
    public int UpcomingOpponentPositionRank { get; set; }
    public int UpcomingOpponentRank { get; set; }
    public string UpcomingSalary { get; set; }
    public int Weight { get; set; }

    public News LatestNews { get; set; }
    public Injury InjuryStatus { get; set; }
    public PlayerSeason PlayerSeason { get; set; }
  }
}
