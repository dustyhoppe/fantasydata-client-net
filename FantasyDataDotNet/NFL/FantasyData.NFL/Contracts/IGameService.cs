using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
  public interface IGameService
  {
    bool IsGameInProgress { get; }
    Games GetByWeek(int week, int season);
  }
}
