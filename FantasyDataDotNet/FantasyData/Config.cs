using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.Configuration;

namespace FantasyData
{
  /// <summary>
  /// 
  /// </summary>
  public class Config
  {
    /// <summary>
    /// 
    /// </summary>
    public static string PrimarySubscriptionKey
    {
      get
      {
        var config = ConfigurationManager.GetSection("fantasyData") as FantasyDataSubscriptionRetrieverSection;
        FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
        return section.PrimarySubscriptionKey;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public static string SecondarySubscriptionKey
    {
      get
      {
        var config = ConfigurationManager.GetSection("fantasyData") as FantasyDataSubscriptionRetrieverSection;
        FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
        return section.SecondarySubscriptionKey;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public static bool UseJSON
    {
      get
      {
        var config = ConfigurationManager.GetSection("fantasyData") as FantasyDataSubscriptionRetrieverSection;
        FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
        return section.UseJSON;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public static Uri ApiBaseUrl
    {
      get
      {
        var config = ConfigurationManager.GetSection("fantasyData") as FantasyDataSubscriptionRetrieverSection;
        FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
        return section.ApiBaseUrl;
      }
    }
  }
}
