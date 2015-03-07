namespace FantasyData.MLB.Entities
{
    using System;
    using System.Collections.Generic;

    public class TeamGames : List<TeamGame>
    { }

    public class TeamGame
    {
        public int StatID { get; set; }
        public int TeamID { get; set; }
        public int SeasonType { get; set; }
        public int Season { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public DateTime Updated { get; set; }
        public int GameID { get; set; }
        public int OpponentID { get; set; }
        public string Opponent { get; set; }
        public DateTime Day { get; set; }
        public DateTime DateTime { get; set; }
        public string HomeOrAway { get; set; }
        public bool IsGameOver { get; set; }
        public int Games { get; set; }
        public int Started { get; set; }
        public int BattingOrder { get; set; }
        public decimal FantasyPoints { get; set; }
        public int AtBats { get; set; }
        public int Runs { get; set; }
        public int Hits { get; set; }
        public int Singles { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }
        public int RunsBattedIn { get; set; }
        public decimal BattingAverage { get; set; }
        public int Outs { get; set; }
        public int Strikeouts { get; set; }
        public int Walks { get; set; }
        public int HitByPitch { get; set; }
        public int Sacrifices { get; set; }
        public int SacrificeFlies { get; set; }
        public int GroundIntoDoublePlay { get; set; }
        public int StolenBases { get; set; }
        public int CaughtStealing { get; set; }
        public int PitchesSeen { get; set; }
        public decimal OnBasePercentage { get; set; }
        public decimal SluggingPercentage { get; set; }
        public decimal OnBasePlusSlugging { get; set; }
        public int Errors { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Saves { get; set; }
        public int InningsPitchedDecimal { get; set; }
        public int TotalOutsPitched { get; set; }
        public int InningsPitchedFull { get; set; }
        public int InningsPitchedOuts { get; set; }
        public decimal EarnedRunAverage { get; set; }
        public int PitchingHits { get; set; }
        public int PitchingRuns { get; set; }
        public int PitchingEarnedRuns { get; set; }
        public int PitchingWalks { get; set; }
        public int PitchingStrikeouts { get; set; }
        public int PitchingHomeRuns { get; set; }
        public int PitchesThrown { get; set; }
        public int PitchesThrownStrikes { get; set; }
        public int WalksHitsPerInningsPitched { get; set; }
        public int PitchingBattingAverageAgainst { get; set; }
    }
}
