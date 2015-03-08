using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class Scores : List<Score>
    { }

    public class Score
    {
        public Score()
        {
            StadiumDetails = new StadiumDetails();
        }

        public int AwayScore { get;set;}
        public int AwayScoreOvertime { get;set;}
        public int AwayScoreQuarter1 { get;set;}
        public int AwayScoreQuarter2 { get;set;}
        public int AwayScoreQuarter3 { get;set;}
        public int AwayScoreQuarter4 { get;set;}
        public string AwayTeam { get;set;}
        public string Channel { get;set;}
        public DateTime Date { get;set;}
        public string Distance { get;set;}
        public string Down { get;set;}
        public string DownAndDistance { get;set;}
        public long GameKey { get;set;}
        public bool Has1stQuarterStarted { get;set;}
        public bool Has2ndQuarterStarted { get;set;}
        public bool Has3rdQuarterStarted { get;set;}
        public bool Has4thQuarterStarted { get;set;}
        public bool HasStarted { get;set;}
        public int HomeScore { get;set;}
        public int HomeScoreOvertime { get; set; }
        public int HomeScoreQuarter1 { get;set;}
        public int HomeScoreQuarter2 { get;set;}
        public int HomeScoreQuarter3 { get;set;}
        public int HomeScoreQuarter4 { get;set;}
        public string HomeTeam { get;set;}
        public bool IsInProgress { get;set;}
        public bool IsOver { get;set;}
        public bool IsOvertime { get;set;}
        public DateTime LastUpdated { get;set;}
        public decimal OverUnder { get;set;}
        public decimal PointSpread { get;set;}
        public string Possession { get;set;}
        public string Quarter { get;set;}
        public string QuarterDescription { get;set;}
        public string RedZone { get;set;}
        public int Season { get;set;}
        public int SeasonType { get;set;}
        public int StadiumID { get;set;}
        public string TimeRemaining { get;set;}
        public int Week { get;set;}
        public string YardLine { get;set;}
        public string YardLineTerritory { get;set;}

        public StadiumDetails StadiumDetails { get;set;}
    }
}
