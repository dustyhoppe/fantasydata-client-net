using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class Injuries : List<Injury>
  { }

  public class Injury
  {
    public string BodyPart { get; set; }
    public bool? DeclaredInactive { get; set; }
    public long InjuryID { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public string Opponent { get; set; }
    public int PlayerID { get; set; }
    public string Position { get; set; }
    public string Practice { get; set; }
    public string PracticeDescription { get; set; }
    public int Season { get; set; }
    public int SeasonType { get; set; }
    public string Status { get; set; }
    public string Team { get; set; }
    public DateTime Updated { get; set; }
    public int Week { get; set; }
  }
}
