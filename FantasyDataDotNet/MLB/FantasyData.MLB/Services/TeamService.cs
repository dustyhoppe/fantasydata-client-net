namespace FantasyData.MLB.Services
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Entities;

    public class TeamService : FantasyDataApiBase, ITeamService
    {
        private static readonly string TeamKey = "Teams";

        public TeamService(string apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(apiBaseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Teams Get()
        {
            var url = string.Format("/{0}", TeamKey);

            return GetRequest<Teams>(url);
        }
    }
}
