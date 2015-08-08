using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface IPlayerGameStatService
    {
        PlayerGame GetByGame(int playerId, int season, int week);
        Task<PlayerGame> GetByGameAsync(int playerId, int season, int week);

        PlayerGames GetByTeamAndWeek(TeamTypes team, int season, int week);
        Task<PlayerGames> GetByTeamAndWeekAsync(TeamTypes team, int season, int week);

        PlayerGames GetByWeek(int season, int week);
        Task<PlayerGames> GetByWeekAsync(int season, int week);
    }
}
