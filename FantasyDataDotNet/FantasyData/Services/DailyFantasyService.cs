using FantasyData.Entities;
using FantasyData.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.Utils;

namespace FantasyData.Services
{
  public class DailyFantasyService : FantasyDataApiBase, IDailyFantasyService
  {
    public static readonly string DailyFantasyPlayersKey = "DailyFantasyPlayers";

    public DailyFantasyService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public IEnumerable<DailyFantasyPlayer> GetDailyFantasyPlayers(DateTime date)
    {
      string url = string.Format("/{0}/{1}", DailyFantasyPlayersKey, date.ToApiDate());

      return GetRequest<List<DailyFantasyPlayer>>(url);
    }
  }
}
