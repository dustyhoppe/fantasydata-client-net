using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class Teams : List<Team>
    { }

    public class Team
    {
        public Team()
        {
            StadiumDetails = new StadiumDetails();
        }

        public decimal AverageDraftPosition { get; set; }
        public decimal AverageDraftPositionPPR { get; set; }
        public int ByeWeek { get; set; }
        public string City { get; set; }
        public string Conference { get; set; }
        public string DefensiveCoordinator { get; set; }
        public string DefensiveScheme { get; set; }
        public string Division { get; set; }
        public string FullName { get; set; }
        public string HeadCoach { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string OffensiveCoordinator { get; set; }
        public string OffensiveScheme { get; set; }
        public int PlayerID { get; set; }
        public string SpecialTeamsCoach { get; set; }
        public int StadiumID { get; set; }
        public int TeamID { get; set; }
        public int UpcomingOpponentPositionRank { get; set; }
        public int UpcomingOpponentRank { get; set; }
        public string UpcomingSalary { get; set; }

        public StadiumDetails StadiumDetails { get; set; }
    }
}
