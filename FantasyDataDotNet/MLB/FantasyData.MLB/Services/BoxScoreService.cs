namespace FantasyData.MLB.Services
{
    using FantasyData.MLB.Contracts;
    using FantasyData.MLB.Entities;
    using FantasyData.Utils;

    using System;

    public class BoxScoreService: FantasyDataApiBase, IBoxScoreService
    {
        private static readonly string BoxScoreKey = "BoxScore";
        private static readonly string BoxScoresKey = "BoxScores";

        public BoxScoreService(string baseApiUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseApiUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BoxScore Get(int id)
        {
            var url = string.Format("/{0}/{1}", BoxScoreKey, id);

            return GetRequest<BoxScore>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public BoxScores GetByDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", BoxScoresKey, date.ToApiDate());

            return GetRequest<BoxScores>(url);
        }
    }
}
