using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface INewsService
    {
        News Get();
        Task<News> GetAsync();

        News GetForTeam(TeamTypes team);
        Task<News> GetForTeamAsync(TeamTypes team);

        News GetForPlayer(int playerId);
        Task<News> GetForPlayerAsync(int playerId);
    }
}
