namespace FantasyData.MLB.Contracts
{
    using FantasyData.MLB.Entities;
    
    using System;

    public interface ITeamGameService
    {
        TeamGames GetByDate(DateTime date);
    }
}
