using GameLibrary.Models;

namespace GameLibrary.Services;

public interface IPlayerStatisticsService
{
    PlayerStatistics GetPlayerStatistics(string playerName);
    void UpdatePlayerStatistics(PlayerStatistics stats);
}
