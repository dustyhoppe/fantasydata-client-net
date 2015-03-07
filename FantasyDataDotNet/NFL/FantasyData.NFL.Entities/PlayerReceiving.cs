using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class PlayerReceivings : List<PlayerReceiving>
  { }

  public class PlayerReceiving
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
    public int FumblesLost { get; set; }
    public int ReceivingLong { get; set; }
    public int ReceivingTargets { get; set; }
    public int ReceivingTouchdowns { get; set; }
    public int ReceivingYards { get; set; }
    public decimal ReceivingYardsPerReception { get; set; }
    public decimal ReceivingYardsPerTarget { get; set; }
    public decimal ReceptionPercentage { get; set; }
    public int Receptions { get; set; }
    public int TwoPointConversionReceptions { get; set; }
  }
}
