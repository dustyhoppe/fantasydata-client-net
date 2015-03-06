using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services.Contracts
{
  using FantasyData.Entities;

  public interface IBoxScoreService
  {
    BoxScore Get(int season, int week, string homeTeam);

    BoxScores RecentlyUpdated(int minutesAgo);
  }
}
