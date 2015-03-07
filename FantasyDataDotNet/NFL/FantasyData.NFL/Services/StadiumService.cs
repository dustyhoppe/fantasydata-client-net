using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
  public class StadiumService : FantasyDataApiBase, IStadiumService
  {
    private static readonly string StadiumsKey = "Stadiums";

    public StadiumService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public StadiumDetails Get()
    {
      string url = string.Format("/{0}", StadiumsKey);

      return GetRequest<StadiumDetails>(url);
    }
  }
}
