using FantasyData.Entities;
using FantasyData.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services
{
  public class SeasonService : FantasyDataApiBase , ISeasonService
  {
    private static readonly string UpcomingSeasonKey = "UpcomingSeason";
    private static readonly string UpcomingWeekKey = "UpcomingWeek";
    private static readonly string CurrentSeasonKey = "CurrentSeason";
    private static readonly string CurrentWeekKey = "CurrentWeek";
    private static readonly string LastCompletedSeasonKey = "LastCompletedSeason";
    private static readonly string LastCompletedWeekKey = "LastCompletedWeek";
    private static readonly string ByesKey = "Byes";


    public SeasonService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }

    /// <summary>
    /// 
    /// </summary>
    public int UpcomingSeason
    {
      get
      {
        string url = string.Format("/{0}", UpcomingSeasonKey);

        var season = GetInt(url);

        return Convert.ToInt32(season);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public int UpcomingWeek
    {
      get
      {
        string url = string.Format("/{0}", UpcomingWeekKey);

        var week = GetInt(url);

        return Convert.ToInt32(week);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public int CurrentSeason
    {
      get
      {
        var url = string.Format("/{0}", CurrentSeasonKey);

        var season = GetInt(url);

        return Convert.ToInt32(season);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public int CurrentWeek
    {
      get
      {
        var url = string.Format("/{0}", CurrentWeekKey);

        var week = GetInt(url);

        return Convert.ToInt32(week);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public int LastCompletedSeason
    {
      get
      {
        var url = string.Format("/{0}", LastCompletedSeasonKey);

        var season = GetInt(url);

        return Convert.ToInt32(season);
      }
    }
    
    /// <summary>
    /// 
    /// </summary>
    public int LastCompletedWeek
    {
      get
      {
        var url = string.Format("/{0}", LastCompletedWeekKey);

        var week = GetInt(url);

        return Convert.ToInt32(week);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="season"></param>
    /// <returns></returns>
    public IEnumerable<TeamByeWeek> GetByeWeeks(int season)
    {
      var url = string.Format("/{0}/{1}", ByesKey, season);

      return GetRequest<List<TeamByeWeek>>(url);
    }
  }
}
