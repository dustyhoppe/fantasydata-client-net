using FantasyData.Services;
using FantasyData.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData
{
  public class FantasyDataClient
  {
    #region Accessors

    public IDailyFantasyService DailyFantasyService { get; private set; }
    public ISeasonService SeasonService { get; private set; }
    public INewsService NewsService { get; private set; }

    #endregion


    #region Constructors

    /// <summary>
    /// 
    /// </summary>
    /// <param name="apiBaseUrl"></param>
    /// <param name="primarySubscriptionKey"></param>
    /// <param name="secondarySubscriptionKey"></param>
    /// <param name="useJSON"></param>
    public FantasyDataClient(Uri apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
    {
      DailyFantasyService = new DailyFantasyService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
      SeasonService = new SeasonService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
      NewsService = new NewsService(apiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
    }

    /// <summary>
    /// 
    /// </summary>
    public FantasyDataClient()
      : this(Config.ApiBaseUrl, Config.PrimarySubscriptionKey, Config.SecondarySubscriptionKey)
    { }


    #endregion
  }
}
