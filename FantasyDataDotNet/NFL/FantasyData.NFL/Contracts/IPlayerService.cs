using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface IPlayerService
    {
        Players GetFreeAgents();
        FantasyPlayers GetFantasyPlayers();
        Player Get(int id);
    }
}
