using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class PlayerPassings : List<PlayerPassing>
  { }

  public class PlayerPassing
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
    public DateTime Updated { get; set; }
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
    public int TwoPointConversionPasses { get; set; }
  }
}
