using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services
{
  using FantasyData.Entities;
  using FantasyData.Services.Contracts;

  public class BoxScoreService : FantasyDataApiBase, IBoxScoreService
  {
    private static readonly string BoxScoreKey = "BoxScore";

    private static readonly string RecentlyUpdatedBoxScoresKey = "RecentlyUpdatedBoxScores";

    public BoxScoreService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="season"></param>
    /// <param name="week"></param>
    /// <param name="homeTeam"></param>
    /// <returns></returns>
    public BoxScore Get(int season, int week, string homeTeam)
    {
      var url = string.Format("/{0}/{1}/{2}/{3}", BoxScoreKey, season, week, homeTeam);

      return this.GetRequest<BoxScore>(url);
    }

    /// <summary>
    /// Returns box scores that have changed in last X minutes.
    /// </summary>
    /// <param name="minutesAgo">Number of minutes. (Must be 1 or 2 )</param>
    /// <returns></returns>
    public BoxScores RecentlyUpdated(int minutesAgo)
    {
      if (minutesAgo < 1 || minutesAgo > 2)
      {
        throw new FantasyDataException("MinutesAgo must be 1 or 2.");
      }

      var url = string.Format("/{0}/{1}", RecentlyUpdatedBoxScoresKey, minutesAgo);

      return this.GetRequest<BoxScores>(url);
    }
  }
}
