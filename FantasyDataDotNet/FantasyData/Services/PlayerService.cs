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
    private static readonly string FantasyPlayerKey = "FantasyPlayers";

    public PlayerService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Players GetFreeAgents()
    {
      var url = string.Format("/{0}", FreeAgentsKey);

      return this.GetRequest<Players>(url);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public FantasyPlayers GetFantasyPlayers()
    {
      var url = string.Format("/{0}", FantasyPlayerKey);

      return this.GetRequest<FantasyPlayers>(url);
    }
  }
}
