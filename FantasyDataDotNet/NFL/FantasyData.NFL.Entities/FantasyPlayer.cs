using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class FantasyPlayers : List<FantasyPlayer>
  { }

  public class FantasyPlayer
  {
    public decimal AverageDraftPosition { get; set; }
    public decimal AverageDraftPositionPPR { get; set; }
    public int ByeWeek { get; set; }
    public string FantasyPlayerKey { get; set; }
    public decimal LastSeasonFantasyPoints { get; set; }
    public string Name { get; set; }
    public int PlayerID { get; set; }
    public string Position { get; set; }
    public decimal? ProjectedFantasyPoints { get; set; }
    public string Team { get; set; }
  }
}
