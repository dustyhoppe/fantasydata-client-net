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
  public class FantasyDataAccountElementCollection : ConfigurationElementCollection
  {
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override ConfigurationElement CreateNewElement()
    {
      return new FantasyDataAccountElement();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((FantasyDataAccountElement)element);
    }
  }
}
