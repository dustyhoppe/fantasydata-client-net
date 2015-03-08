using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class ScoringPlays : List<ScoringPlay>
  { }

  public class ScoringPlay
  {
    public int AwayScore { get; set; }
    public string AwayTeam { get; set; }
    public DateTime Date { get; set; }
    public long GameKey { get; set; }
    public int HomeScore { get; set; }
    public string HomeTeam { get; set; }
    public string PlayDescription { get; set; }
    public string Quarter { get; set; }
    public long ScoringPlayID { get; set; }
    public int Season { get; set; }
    public int SeasonType { get; set; }
    public int Sequence { get; set; }
    public string Team { get; set; }
    public string TimeRemaining { get; set; }
    public int Week { get; set; }
  }
}
