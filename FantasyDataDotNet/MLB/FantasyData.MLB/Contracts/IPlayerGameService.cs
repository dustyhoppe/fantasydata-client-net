namespace FantasyData.MLB.Contracts
{
    using FantasyData.MLB.Entities;
    
    using System;

    public interface IPlayerGameService
    {
        PlayerGames GetByDate(DateTime date);
    }
}
