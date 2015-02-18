using FantasyData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services.Contracts
{
  public interface ISeasonService
  {
    int UpcomingSeason { get; }
    int UpcomingWeek { get; }
    int CurrentSeason { get; }
    int CurrentWeek { get; }
    int LastCompletedSeason { get; }
    int LastCompletedWeek { get; }
    IEnumerable<TeamByeWeek> GetByeWeeks(int season);
  }
}
