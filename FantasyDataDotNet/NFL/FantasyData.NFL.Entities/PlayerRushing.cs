using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class PlayerRushings : List<PlayerRushing>
  { }

  public class PlayerRushing
  {
    public decimal FantasyPoints { get; set; }
    public string FantasyPosition { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public int PlayerID { get; set; }
    public string Position { get; set; }
    public string PositionCategory { get; set; }
    public string ShortName { get; set; }
    public string Team { get; set; }
    public DateTime?  Updated { get; set; }
    public int FumblesLost { get; set; }
    public int RushingAttempts { get; set; }
    public int RushingLong { get; set; }
    public int RushingTouchdowns { get; set; }
    public int RushingYards { get; set; }
    public decimal RushingYardsPerAttempt { get; set; }
    public int TwoPointConversionRuns { get; set; }
  }
}
