using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class ScoringDetails : List<ScoringDetail>
  {

  }

  public class ScoringDetail
  {
    public long GameKey { get; set; }
    public int Length { get; set; }
    public long PlayerGameID { get; set; }
    public int PlayerID { get; set; }
    public long ScoringDetailID { get; set; }
    public string ScoringType { get; set; }
    public int Season { get; set; }
    public int SeasonType { get; set; }
    public string Team { get; set; }
    public int Week { get; set; }
  }
}
