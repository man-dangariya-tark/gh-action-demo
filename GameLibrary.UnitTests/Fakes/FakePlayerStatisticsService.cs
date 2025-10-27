using GameLibrary.Models;
using GameLibrary.Services;

namespace GameLibrary.UnitTests;

public class FakePlayerStatisticsService : IPlayerStatisticsService
{
    private readonly Dictionary<string, PlayerStatistics> statistics = new();

    public PlayerStatistics GetPlayerStatistics(string playerName)
    {
        return statistics[playerName];
    }

    public void UpdatePlayerStatistics(PlayerStatistics stats)
    {
        statistics[stats.PlayerName] = stats;
    }
}
