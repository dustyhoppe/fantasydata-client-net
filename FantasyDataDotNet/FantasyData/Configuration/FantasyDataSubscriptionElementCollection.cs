using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Configuration
{
  /// <summary>
  /// 
  /// </summary>
  [ConfigurationCollection(typeof(FantasyDataSubscriptionElement))]
  public class FantasyDataSubscriptionElementCollection : ConfigurationElementCollection
  {
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override ConfigurationElement CreateNewElement()
    {
      return new FantasyDataSubscriptionElement();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((FantasyDataSubscriptionElement)element).Name;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public FantasyDataSubscriptionElement this[int index]
    {
      get
      {
        return (FantasyDataSubscriptionElement)base.BaseGet(index);
      }
      set
      {
        if (base.BaseGet(index) != null)
          base.BaseRemoveAt(index);

        this.BaseAdd(index, value);
      }
    }
  }
}
