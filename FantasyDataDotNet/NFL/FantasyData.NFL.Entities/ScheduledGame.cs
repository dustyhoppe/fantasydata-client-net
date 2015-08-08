using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class ScheduledGames : List<ScheduledGame>
    { }

    public class ScheduledGame
    {
        public string GameKey { get; set; }
        public int SeasonType { get; set; }
        public int Season { get; set; }
        public int Week { get; set; }
        public DateTime Date { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public string Channel { get; set; }
        public double? Spread { get; set; }
        public int? OverUnder { get; set; }
        public int StadiumID { get; set; }
        public StadiumDetails StadiumDetails { get; set; }
    }
}
