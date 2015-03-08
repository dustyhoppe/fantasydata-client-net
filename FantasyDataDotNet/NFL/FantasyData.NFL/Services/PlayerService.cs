using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class PlayerService : FantasyDataApiBase, IPlayerService
    {
        private static readonly string FreeAgentsKey = "FreeAgents";
        private static readonly string FantasyPlayerKey = "FantasyPlayers";
        private static readonly string PlayerKey = "Player";

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Player Get(int id)
        {
            var url = string.Format("/{0}/{1}", PlayerKey, id);
            return this.GetRequest<Player>(url);
        }
    }
}
