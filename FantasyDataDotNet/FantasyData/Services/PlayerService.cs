using FantasyData.Entities;
using FantasyData.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services
{
  public class PlayerService : FantasyDataApiBase , IPlayerService
  {
    private static readonly string FreeAgentsKey = "FreeAgents";

    public PlayerService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Players GetFreeAgents()
    {
      string url = string.Format("/{0}", FreeAgentsKey);

      return GetRequest<Players>(url);
    }
  }
}
