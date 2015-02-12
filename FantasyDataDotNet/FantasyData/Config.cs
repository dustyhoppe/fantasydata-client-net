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
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public static string SecondarySubscriptionKey
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public static bool UseJSON
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public static string ApiBaseUrl
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    static Config()
    {
      var configuration = ConfigurationManager.GetSection("fantasyData") as FantasyDataAccountRetrieverSection;
    }
  }
}
