using FantasyData.Entities;
using FantasyData.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services
{
  public class TeamService : FantasyDataApiBase , ITeamService
  {
    private static readonly string StandingsKey = "Standings";

    public TeamService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="season"></param>
    /// <returns></returns>
    public Standings GetStandingsBySeason(int season)
    {
      string url = string.Format("/{0}/{1}", StandingsKey, season);

      return GetRequest<Standings>(url);
    }
  }
}
