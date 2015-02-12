using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Configuration
{
  public class FantasyDataAccountRetrieverSection : ConfigurationSection
  {
    private const string USEJSON = "useJSON";
    private const string APIBASEURL = "baseURL";
    private const string PRIMARYSUBSCRIPTION = "primarySubscriptionKey";
    private const string SECONDARYSUBSCRIPTION = "secondarySubscriptionKey";

    /// <summary>
    /// Should FantasData.NET use JSON or XML. Default is false (XML).
    /// </summary>
    [ConfigurationProperty(USEJSON)]
    public bool UseJSON
    {
      get
      {
        if (base[USEJSON] != null)
          return (bool)base[USEJSON];

        return false;
      }
      set
      {
        base[USEJSON] = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [ConfigurationProperty(APIBASEURL)]
    public string ApiBaseUrl
    {
      get
      {
        return base[APIBASEURL].ToString();
      }
      set
      {
        base[APIBASEURL] = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [ConfigurationProperty(PRIMARYSUBSCRIPTION)]
    public string PrimarySubscriptionKey
    {
      get
      {
        return base[PRIMARYSUBSCRIPTION].ToString();
      }
      set
      {
        base[PRIMARYSUBSCRIPTION] = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [ConfigurationProperty(SECONDARYSUBSCRIPTION)]
    public string SecondarySubscriptionKey
    {
      get
      {
        if (base[SECONDARYSUBSCRIPTION] != null)
          return base[SECONDARYSUBSCRIPTION].ToString();

        return string.Empty;
      }
      set
      {
        base[SECONDARYSUBSCRIPTION] = value;
      }
    }
  }
}
