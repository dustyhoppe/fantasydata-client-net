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

    #endregion


    #region Constructors

    /// <summary>
    /// 
    /// </summary>
    /// <param name="apiBaseUrl"></param>
    /// <param name="primarySubscriptionKey"></param>
    /// <param name="secondarySubscriptionKey"></param>
    /// <param name="useJSON"></param>
    public FantasyDataClient(Uri apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey, bool useJSON)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    public FantasyDataClient()
      : this(Config.ApiBaseUrl, Config.PrimarySubscriptionKey, Config.SecondarySubscriptionKey, Config.UseJSON)
    { }


    #endregion
  }
}
