using FantasyData.Entities;
using FantasyData.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services
{
  public class InjuryService : FantasyDataApiBase, IInjuryService
  {
    private static readonly string InjuriesKey = "Injuries";

    public InjuryService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="week"></param>
    /// <param name="season"></param>
    /// <returns></returns>
    public Injuries GetByWeek(int week, int season)
    {
      var url = string.Format("/{0}", InjuriesKey);

      return GetRequest<Injuries>(url);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="team"></param>
    /// <param name="week"></param>
    /// <param name="season"></param>
    /// <returns></returns>
    public Injuries GetByWeekAndTeam(Teams team, int week, int season)
    {
      string url = string.Format("/{0}/{1}/{2}/{3}", InjuriesKey, season, week, team.ToString());

      return GetRequest<Injuries>(url);
    }
  }
}
