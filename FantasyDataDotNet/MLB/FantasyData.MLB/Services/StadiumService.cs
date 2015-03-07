namespace FantasyData.MLB.Services
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Entities;

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
