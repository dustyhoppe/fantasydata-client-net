using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class KickPuntReturns : List<KickPuntReturn>
  { }

  public class KickPuntReturn
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
    public int KickReturnLong { get; set; }
    public int KickReturnTouchdowns { get; set; }
    public int KickReturnYards { get; set; }
    public int KickReturnYardsPerAttempt { get; set; }
    public int KickReturns { get; set; }
    public int PuntReturnLong { get; set; }
    public int PuntReturnTouchdowns { get; set; }
    public int PuntReturnYards { get; set; }
    public int PuntReturnYardsPerAttempt { get; set; }
    public int PuntReturns { get; set; }
  }
}
