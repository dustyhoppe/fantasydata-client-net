namespace FantasyData.MLB.Contracts
{
    using FantasyData.MLB.Entities;

    public interface IPlayerService
    {
        Players GetByTeam(string shortName);
        Players GetActive();
        Players GetFreeAgents();
    }
}
