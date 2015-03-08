using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class TeamByeWeeks : List<TeamByeWeek>
    { }

    public class TeamByeWeek
    {
        public string Team { get; set; }
        public int Season { get; set; }
        public int Week { get; set; }
    }
}
