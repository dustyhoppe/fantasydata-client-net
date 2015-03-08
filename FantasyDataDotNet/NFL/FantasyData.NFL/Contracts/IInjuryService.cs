using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
  public interface IInjuryService
  {
    Injuries GetByWeek(int week, int season);
    Injuries GetByWeekAndTeam(TeamTypes team, int week, int season);
  }
}
