using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class FantasyDefenseSeasons : List<FantasyDefenseSeason>
  { }

  public class FantasyDefenseSeason
  {
    public FantasyDefenseSeason()
    {
      ScoringDetails = new ScoringDetails();
    }

    public int AssistedTackles { get; set; }
    public int BlockedKickReturnTouchdowns { get; set; }
    public int BlockedKickReturnYards { get; set; }
    public int BlockedKicks { get; set; }
    public int DefensiveTouchdowns { get; set; }
    public decimal FantasyPoints { get; set; }
    public decimal FantasyPointsAllowed { get; set; }
    public int FieldGoalReturnTouchdowns { get; set; }
    public int FieldGoalReturnYards { get; set; }
    public int FourthDownAttempts { get; set; }
    public int FourthDownConversions { get; set; }
    public int FumbleReturnTouchdowns { get; set; }
    public int FumbleReturnYards { get; set; }
    public int FumblesForced { get; set; }
    public int FumblesRecovered { get; set; }
    public int Games { get; set; }
    public int? Humidity { get; set; }
    public int InterceptionReturnTouchdowns { get; set; }
    public int InterceptionReturnYards { get; set; }
    public int Interceptions { get; set; }
    public int KickReturnLong { get; set; }
    public int KickReturnTouchdowns { get; set; }
    public int KickReturnYards { get; set; }
    public int KickReturns { get; set; }
    public decimal KickerFantasyPointsAllowed { get; set; }
    public int PassesDefended { get; set; }
    public int PointsAllowed { get; set; }
    public int PointsAllowedByDefenseSpecialTeams { get; set; }
    public int PuntReturnLong { get; set; }
    public int PuntReturnTouchdowns { get; set; }
    public int PuntReturnYards { get; set; }
    public int PuntReturns { get; set; }
    public decimal QuarterbackFantasyPointsAllowed { get; set; }
    public int QuarterbackHits { get; set; }
    public decimal RunningbackFantasyPointsAllowed { get; set; }
    public int SackYards { get; set; }
    public int Sacks { get; set; }
    public int Safeties { get; set; }
    public int Season { get; set; }
    public int SeasonType { get; set; }
    public int SoloTackles { get; set; }
    public int SpecialTeamsTouchdowns { get; set; }
    public int TacklesForLoss { get; set; }
    public string Team { get; set; }
    public int? Temperature { get; set; }
    public int ThirdDownAttempts { get; set; }
    public int ThirdDownConversions { get; set; }
    public decimal TightEndFantasyPointsAllowed { get; set; }
    public int TouchdownsScored { get; set; }
    public decimal WideReceiverFantasyPointsAllowed { get; set; }
    public int? WindSpeed { get; set; }

    public ScoringDetails ScoringDetails { get; set; }
  }
}
