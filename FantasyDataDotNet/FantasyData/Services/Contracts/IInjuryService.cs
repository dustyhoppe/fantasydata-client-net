using FantasyData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Services.Contracts
{
  public interface IInjuryService
  {
    Injuries GetByWeek(int week, int season);
    Injuries GetByWeekAndTeam(Teams team, int week, int season);
  }
}
