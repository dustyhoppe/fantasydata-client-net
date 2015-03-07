namespace FantasyData.MLB.Contracts
{
    using FantasyData.MLB.Entities;

    public interface IPlayerSeasonService
    {
        PlayerSeasons Get(int season);
        PlayerSeasons GetByTeam(int season, string shortName);
    }
}
