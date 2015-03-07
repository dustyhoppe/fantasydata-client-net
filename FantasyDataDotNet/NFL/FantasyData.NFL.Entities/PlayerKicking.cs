using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class PlayerKickings : List<PlayerKicking>
  { }

  public class PlayerKicking
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
    public DateTime? Updated { get; set; }
    public int ExtraPointsAttempted { get; set; }
    public int ExtraPointsMade { get; set; }
    public decimal FieldGoalPercentage { get; set; }
    public int FieldGoalsAttempted { get; set; }
    public int FieldGoalsLongestMade { get; set; }
    public int FieldGoalsMade { get; set; }
  }
}
