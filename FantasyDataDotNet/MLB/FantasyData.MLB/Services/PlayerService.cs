namespace FantasyData.MLB.Services
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Entities;

    public class PlayerService : FantasyDataApiBase , IPlayerService
    {
        private static readonly string PlayersKey = "Players";
        private static readonly string FreeAgentKey = "FreeAgents";

        public PlayerService(string apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(apiBaseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shortName"></param>
        /// <returns></returns>
        public Players GetByTeam(string shortName)
        {
            var url = string.Format("/{0}/{1}", PlayersKey, shortName);

            return GetRequest<Players>(url);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Players GetActive()
        {
            var url = string.Format("/{0}", PlayersKey);

            return GetRequest<Players>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Players GetFreeAgents()
        {
            var url = string.Format("/{0}", FreeAgentKey);

            return GetRequest<Players>(url);
        }
    }
}
