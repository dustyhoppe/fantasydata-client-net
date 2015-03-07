using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class PlayerDefenses : List<PlayerDefense>
  { }

  public class PlayerDefense
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
    public DateTime? Updated { get; set;  }
    public int AssistedTackles { get; set; }
    public int FumblesForced { get; set; }
    public int FumblesRecovered { get; set; }
    public int InterceptionReturnTouchdowns { get; set; }
    public int InterceptionReturnYards { get; set; }
    public int Interceptions { get; set; }
    public int PassesDefended { get; set; }
    public int SackYards { get; set; }
    public decimal Sacks { get; set; }
    public int SoloTackles { get; set; }
    public int Tackles { get; set; }
  }
}
