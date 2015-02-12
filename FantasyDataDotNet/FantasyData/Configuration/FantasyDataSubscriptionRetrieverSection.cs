using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Configuration
{
  public class FantasyDataSubscriptionRetrieverSection : ConfigurationSection
  {
    /// <summary>
    /// 
    /// </summary>
    [ConfigurationProperty("defaultSubscription")]
    public string DefaultSubscription
    {
      get { return (string)base["defaultSubscription"]; }
      set { base["defaultSubscription"] = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    [ConfigurationProperty("subscriptions", IsDefaultCollection = true)]
    public FantasyDataSubscriptionElementCollection Subscriptions
    {
      get { return (FantasyDataSubscriptionElementCollection)this["subscriptions"]; }
      set { this["subscriptions"] = value; }
    }


    /// <summary>
    /// Should FantasData.NET use JSON or XML. Default is false (XML).
    /// </summary>
    [ConfigurationProperty("useJson")]
    public bool UseJSON
    {
      get
      {
        if (base["useJson"] != null)
          return (bool)base["useJson"];

        return false;
      }
      set
      {
        base["useJson"] = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [ConfigurationProperty("baseUrl")]
    public string ApiBaseUrl
    {
      get
      {
        return base["baseUrl"].ToString();
      }
      set
      {
        base["baseUrl"] = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [ConfigurationProperty("primarySubscriptionKey")]
    public string PrimarySubscriptionKey
    {
      get
      {
        return base["primarySubscriptionKey"].ToString();
      }
      set
      {
        base["primarySubscriptionKey"] = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [ConfigurationProperty("secondarySubscriptionKey")]
    public string SecondarySubscriptionKey
    {
      get
      {
        if (base["secondarySubscriptionKey"] != null)
          return base["secondarySubscriptionKey"].ToString();

        return string.Empty;
      }
      set
      {
        base["secondarySubscriptionKey"] = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public FantasyDataSubscriptionElement GetFirstOrDefault()
    {
      FantasyDataSubscriptionElement result = null;

      if (!string.IsNullOrEmpty(this.DefaultSubscription))
      {
        foreach (FantasyDataSubscriptionElement element in this.Subscriptions)
        {
          if (element.Name == this.DefaultSubscription)
          {
            result = element;
            break;
          }
        }
      }
      else
      {
        // If there are account elements in the web.config then ..
        if (this.Subscriptions.Count > 0)
        {
          result = this.Subscriptions[0] as FantasyDataSubscriptionElement;
        }
      }

      if (result == null) { throw new ConfigurationErrorsException("No subscriptions listed for FantasyData in web.config"); }
      else
      {
        return result;
      }
    }



    public string GetPrimaryKeyForDefaultOrFirstSite()
    {
      FantasyDataSubscriptionElement result = null;

      if (!string.IsNullOrEmpty(this.DefaultSubscription))
      {
        foreach (FantasyDataSubscriptionElement element in this.Subscriptions)
        {
          if (element.Name == this.DefaultSubscription)
          {
            result = element;
            break;
          }
        }
      }
      else
      {
        // If there are account elements in the web.config then ..
        if (this.Subscriptions.Count > 0)
        {
          result = this.Subscriptions[0] as FantasyDataSubscriptionElement;
        }
      }

      if (result == null) { throw new ConfigurationErrorsException("No subscriptions listed for FantasyData in web.config"); }
      else
      {
        return result.PrimarySubscriptionKey;
      }
    }
  }
}
