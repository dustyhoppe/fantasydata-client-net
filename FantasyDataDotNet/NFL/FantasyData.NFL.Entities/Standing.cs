using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class Standings : List<Standing>
  { }

  public class Standing
  {
    public string Conference { get; set; }
    public int ConferenceLosses { get; set; }
    public int ConferenceWins { get; set; }
    public string Division { get; set; }
    public int DivisionLosses { get; set; }
    public int DivisionWins { get; set; }
    public int Losses { get; set; }
    public string Name { get; set; }
    public int NetPoints { get; set; }
    public decimal Percentage { get; set; }
    public int PointsAgainst { get; set; }
    public int PointsFor { get; set; }
    public int Season { get; set; }
    public int SeasonType { get; set; }
    public string Team { get; set; }
    public int Ties { get; set; }
    public int Touchdowns { get; set; }
    public int Wins { get; set; }
  }
}
