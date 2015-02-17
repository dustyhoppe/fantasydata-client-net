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
    int GetCurrentSeason();
    IEnumerable<TeamByeWeek> GetByeWeeks(int season);
  }
}
