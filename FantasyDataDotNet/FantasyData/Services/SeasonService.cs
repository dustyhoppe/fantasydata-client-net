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
    private static readonly string CurrentSeasonKey = "CurrentSeason";
    private static readonly string ByesKey = "Byes";


    public SeasonService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }


    public int GetCurrentSeason()
    {
      var url = string.Format("/{0}", CurrentSeasonKey);

      var season = GetInt(url);

      return Convert.ToInt32(season);
    }

    public IEnumerable<TeamByeWeek> GetByeWeeks(int season)
    {
      var url = string.Format("/{0}/{1}", ByesKey, season);

      return GetRequest<List<TeamByeWeek>>(url);
    }
  }
}
