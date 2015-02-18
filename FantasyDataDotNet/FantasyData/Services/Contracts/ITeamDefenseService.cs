using FantasyData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services.Contracts
{
  public interface ITeamDefenseService
  {
    FantasyDefenseGames GetGames(int week, int season);
    FantasyDefenseSeasons GetSeasons(int season);
  }
}
