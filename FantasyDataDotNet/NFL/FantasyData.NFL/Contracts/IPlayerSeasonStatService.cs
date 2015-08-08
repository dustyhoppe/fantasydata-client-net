using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface IPlayerSeasonStatService
    {
        PlayerSeasons GetByPlayer(int playerId, int season);
        Task<PlayerSeasons> GetByPlayerAsync(int playerId, int season);

        PlayerSeasons GetByTeam(TeamTypes team, int season);
        Task<PlayerSeasons> GetByTeamAsync(TeamTypes team, int season);
    }
}
