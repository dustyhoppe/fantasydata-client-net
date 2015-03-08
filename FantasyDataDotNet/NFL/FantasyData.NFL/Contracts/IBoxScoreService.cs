using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    using FantasyData.NFL.Entities;

    public interface IBoxScoreService
    {
        BoxScore Get(int season, int week, string homeTeam);
        BoxScores GetForSeasonAndWeek(int season, int week);
        BoxScores RecentlyUpdated(int minutesAgo);
        BoxScores GetActive();
        BoxScores GetFinal();
    }
}
