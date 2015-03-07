using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class PlayerPuntings : List<PlayerPunting>
  { }

  public class PlayerPunting
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
    public decimal PuntAverage { get; set; }
    public int PuntInside20 { get; set; }
    public int PuntTouchbacks { get; set; }
    public int PuntYards { get; set; }
    public int Punts { get; set; }
  }
}
