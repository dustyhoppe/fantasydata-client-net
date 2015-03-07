namespace FantasyData.MLB.Contracts
{
    using FantasyData.MLB.Entities;

    public interface ITeamSeasonService
    {
        TeamSeasons Get(int season);
    }
}
