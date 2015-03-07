namespace FantasyData.MLB.Contracts
{
    using FantasyData.MLB.Entities;
    
    using System;

    public interface IBoxScoreService
    {
        BoxScore Get(int id);
        BoxScores GetByDate(DateTime date);
    }
}
