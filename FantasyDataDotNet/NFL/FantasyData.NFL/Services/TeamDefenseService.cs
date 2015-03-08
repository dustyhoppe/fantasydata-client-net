using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
  public class TeamDefenseService : FantasyDataApiBase, ITeamDefenseService
  {
    private static readonly string FantasyDefenseGameByWeekKey = "FantasyDefenseByGame";
    private static readonly string FantasyDefenseSeasonKey = "FantasyDefenseBySeason";

    public TeamDefenseService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="week"></param>
    /// <param name="season"></param>
    /// <returns></returns>
    public FantasyDefenseGames GetGames(int season, int week)
    {
      string url = string.Format("/{0}/{1}/{2}", FantasyDefenseGameByWeekKey, season, week);

      return GetRequest<FantasyDefenseGames>(url);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="season"></param>
    /// <returns></returns>
    public FantasyDefenseSeasons GetSeasons(int season)
    {
      string url = string.Format("/{0}/{1}", FantasyDefenseSeasonKey, season);

      return GetRequest<FantasyDefenseSeasons>(url);
    }
  }
}
