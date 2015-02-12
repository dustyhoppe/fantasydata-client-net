using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace FantasyData
{
  public class FantasyDataApiBase
  {
    #region Properties and Accessors

    protected string BaseUrl { get; private set; }
    protected bool UseJSON { get; private set; }
    protected string PrimarySubscriptionKey { get; private set; }
    protected string SecondarySubscriptionKey { get; private set; }

    private static string _userAgent;

    private static string UserAgent
    {
      get
      {
        if(_userAgent == null)
        {
          _userAgent = String.Format("FantasyData.NET RestSharp Client v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }
        return _userAgent;
      }
    }

    private RestClient _client;

    #endregion

    #region Constructors

    protected FantasyDataApiBase(string baseUrl, string primarySubscriptionKey)
    {
      if (string.IsNullOrEmpty(primarySubscriptionKey))
        throw new ArgumentException("Primary Subscription Key is required.");

      if (string.IsNullOrEmpty(baseUrl))
        throw new ArgumentException("Api Base Url is required.");

      PrimarySubscriptionKey = primarySubscriptionKey;
      BaseUrl = baseUrl;
      UseJSON = false;

      _client = new RestClient();
      _client.UserAgent = UserAgent;
      _client.BaseUrl = Config.ApiBaseUrl;

      //TODO: Setup Authenticator
      //_client.Authenticator = 
    }


    protected FantasyDataApiBase(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey, bool useJSON)
      : this(baseUrl, primarySubscriptionKey)
    {
      UseJSON = useJSON;
      SecondarySubscriptionKey = secondarySubscriptionKey;
    }

    #endregion
  }
}
