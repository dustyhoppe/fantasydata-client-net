using FantasyData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services.Contracts
{
  public interface INewsService
  {
    News Get();
    News GetForTeam(Teams team);
    News GetForPlayer(int playerId);
  }
}
