namespace FantasyData.MLB.Contracts
{
    using FantasyData.MLB.Entities;
    
    using System;

    public interface IGameService
    {
        Games GetByDate(DateTime date);
        Games GetBySeason(int season);
    }
}
