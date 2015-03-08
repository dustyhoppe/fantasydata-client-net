using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class PlayerSeasons : List<PlayerSeason>
    { }

    public class PlayerSeason
    {
        public PlayerSeason()
        {
            ScoringDetails = new ScoringDetails();
        }

        public int Activated { get; set; }
        public int AssistedTackles { get; set; }
        public int BlockedKickReturnTouchdowns { get; set; }
        public int BlockedKickReturnYards { get; set; }
        public int BlockedKicks { get; set; }
        public decimal CustomD365FantasyPoints { get; set; }
        public int DefensiveSnapsPlayed { get; set; }
        public int DefensiveTeamSnaps { get; set; }
        public int DefensiveTouchdowns { get; set; }
        public int ExtraPointsAttempted { get; set; }
        public int ExtraPointsHadBlocked { get; set; }
        public int ExtraPointsMade { get; set; }
        public decimal FantasyPoints { get; set; }
        public decimal FantasyPointsPPR { get; set; }
        public string FantasyPosition { get; set; }
        public decimal FieldGoalPercentage { get; set; }
        public int FieldGoalReturnTouchdowns { get; set; }
        public int FieldGoalReturnYards { get; set; }
        public int FieldGoalsAttempted { get; set; }
        public int FieldGoalsHadBlocked { get; set; }
        public int FieldGoalsLongestMade { get; set; }
        public int FieldGoalsMade { get; set; }
        public int FumbleReturnTouchdowns { get; set; }
        public int FumbleReturnYards { get; set; }
        public int Fumbles { get; set; }
        public int FumblesForced { get; set; }
        public int FumblesLost { get; set; }
        public int FumblesOutOfBounds { get; set; }
        public int FumblesOwnRecoveries { get; set; }
        public int FumblesRecovered { get; set; }
        public int Humidity { get; set; }
        public int InterceptionReturnTouchdowns { get; set; }
        public int InterceptionReturnYards { get; set; }
        public int Interceptions { get; set; }
        public int KickReturnFairCatches { get; set; }
        public int KickReturnLong { get; set; }
        public int KickReturnTouchdowns { get; set; }
        public int KickReturnYards { get; set; }
        public decimal KickReturnYardsPerAttempt { get; set; }
        public int KickReturns { get; set; }
        public int MiscAssistedTackles { get; set; }
        public int MiscFumblesForced { get; set; }
        public int MiscFumblesRecovered { get; set; }
        public int MiscSoloTackles { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int OffensiveSnapsPlayed { get; set; }
        public int OffensiveTeamSnaps { get; set; }
        public int OffensiveTouchdowns { get; set; }
        public int PassesDefended { get; set; }
        public int PassingAttempts { get; set; }
        public decimal PassingCompletionPercentage { get; set; }
        public int PassingCompletions { get; set; }
        public int PassingInterceptions { get; set; }
        public int PassingLong { get; set; }
        public decimal PassingRating { get; set; }
        public int PassingSackYards { get; set; }
        public int PassingSacks { get; set; }
        public int PassingTouchdowns { get; set; }
        public int PassingYards { get; set; }
        public decimal PassingYardsPerAttempt { get; set; }
        public decimal PassingYardsPerCompletion { get; set; }
        public int Played { get; set; }
        public int PlayerID { get; set; }
        public long PlayerSeasonID { get; set; }
        public string Position { get; set; }
        public string PositionCategory { get; set; }
        public decimal PuntAverage { get; set; }
        public int PuntInside20 { get; set; }
        public int PuntLong { get; set; }
        public decimal PuntNetAverage { get; set; }
        public int PuntNetYards { get; set; }
        public int PuntReturnFairCatches { get; set; }
        public int PuntReturnLong { get; set; }
        public int PuntReturnTouchdowns { get; set; }
        public int PuntReturnYards { get; set; }
        public decimal PuntReturnYardsPerAttempt { get; set; }
        public int PuntReturns { get; set; }
        public int PuntTouchbacks { get; set; }
        public int PuntYards { get; set; }
        public int Punts { get; set; }
        public int PuntsHadBlocked { get; set; }
        public int QuarterbackHits { get; set; }
        public int ReceivingLong { get; set; }
        public int ReceivingTargets { get; set; }
        public int ReceivingTouchdowns { get; set; }
        public int ReceivingYards { get; set; }
        public decimal ReceivingYardsPerReception { get; set; }
        public decimal ReceivingYardsPerTarget { get; set; }
        public decimal ReceptionPercentage { get; set; }
        public int Receptions { get; set; }
        public int RushingAttempts { get; set; }
        public int RushingLong { get; set; }
        public int RushingTouchdowns { get; set; }
        public int RushingYards { get; set; }
        public int RushingYardsPerAttempt { get; set; }
        public int SackYards { get; set; }
        public decimal Sacks { get; set; }
        public int Safeties { get; set; }
        public int SafetiesAllowed { get; set; }
        public ScoringDetails ScoringDetails { get; set; }
        public int Season { get; set; }
        public int SeasonType { get; set; }
        public string ShortName { get; set; }
        public int SoloTackles { get; set; }
        public int SpecialTeamsAssistedTackles { get; set; }
        public int SpecialTeamsFumblesForced { get; set; }
        public int SpecialTeamsFumblesRecovered { get; set; }
        public int SpecialTeamsSnapsPlayed { get; set; }
        public int SpecialTeamsSoloTackles { get; set; }
        public int SpecialTeamsTeamSnaps { get; set; }
        public int SpecialTeamsTouchdowns { get; set; }
        public int Started { get; set; }
        public int Tackles { get; set; }
        public int TacklesForLoss { get; set; }
        public string Team { get; set; }
        public decimal Temperature { get; set; }
        public int Touchdowns { get; set; }
        public int TwoPointConversionPasses { get; set; }
        public int TwoPointConversionReceptions { get; set; }
        public int TwoPointConversionRuns { get; set; }
        public decimal WindSpeed { get; set; }
    }
}
