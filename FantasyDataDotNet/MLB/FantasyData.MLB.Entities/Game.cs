namespace FantasyData.MLB.Entities
{
    using System;
    using System.Collections.Generic;

    public class Games : List<Game>
    { }

    public class Game
    {
        public int GameID { get; set; }
        public int Season { get; set; }
        public int SeasonType { get; set; }
        public string Status { get; set; }
        public DateTime Day { get; set; }
        public DateTime DateTime { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public int AwayTeamID { get; set; }
        public int HomeTeamID { get; set; }
        public int StadiumID { get; set; }
        public string Channel { get; set; }
        public int Inning { get; set; }
        public string InningHalf { get; set; }
        public int AwayTeamRuns { get; set; }
        public int HomeTeamRuns { get; set; }
        public int AwayTeamHits { get; set; }
        public int HomeTeamHits { get; set; }
        public int AwayTeamErrors { get; set; }
        public int HomeTeamErrors { get; set; }
        public int WinningPitcherID { get; set; }
        public int LosingPitcherID { get; set; }
        public int SavingPitcherID { get; set; }
        public int? Attendance { get; set; }
    }
}
