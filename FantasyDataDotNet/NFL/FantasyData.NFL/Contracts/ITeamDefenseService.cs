using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface ITeamDefenseService
    {
        FantasyDefenseGames GetGames(int season, int week);
        Task<FantasyDefenseGames> GetGamesAsync(int season, int week);

        FantasyDefenseSeasons GetSeasons(int season);
        Task<FantasyDefenseSeasons> GetSeasonsAsync(int season);
    }
}
