using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface ISeasonService
    {
        int UpcomingSeason { get; }
        int UpcomingWeek { get; }
        int CurrentSeason { get; }
        int CurrentWeek { get; }
        int LastCompletedSeason { get; }
        int LastCompletedWeek { get; }

        TeamByeWeeks GetByeWeeks(int season);
        Task<TeamByeWeeks> GetByeWeeksAsync(int season);

        Scores GetScores(int season);
        Task<Scores> GetScoresAsync(int season);
    }
}
