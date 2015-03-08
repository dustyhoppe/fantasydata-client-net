using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
  public class PlayerSeasonStatService : FantasyDataApiBase, IPlayerSeasonStatService
  {
    private static readonly string PlayerSeasonStatsByTeamKey = "PlayerSeasonStatsByTeam";
    private static readonly string PlayerSeasonStatsByPlayerKey = "PlayerSeasonStatsByPlayerID";

    public PlayerSeasonStatService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="team"></param>
    /// <param name="season"></param>
    /// <returns></returns>
    public PlayerSeasons GetByTeam(Entities.TeamTypes team, int season)
    {
      string url = string.Format("/{0}/{1}/{2}", PlayerSeasonStatsByTeamKey, season, team.ToString());

      return GetRequest<PlayerSeasons>(url);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="playerId"></param>
    /// <param name="season"></param>
    /// <returns></returns>
    public PlayerSeasons GetByPlayer(int playerId, int season)
    {
      string url = string.Format("/{0}/{1}/{2}", PlayerSeasonStatsByPlayerKey, season, playerId);

      return GetRequest<PlayerSeasons>(url);
    }
  }
}
