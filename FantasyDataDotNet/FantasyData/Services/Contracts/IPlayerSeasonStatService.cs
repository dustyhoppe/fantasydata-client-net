using FantasyData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services.Contracts
{
  public interface IPlayerSeasonStatService
  {
    PlayerSeasons GetByPlayer(int playerId, int season);
    PlayerSeasons GetByTeam(Teams team, int season);
  }
}
