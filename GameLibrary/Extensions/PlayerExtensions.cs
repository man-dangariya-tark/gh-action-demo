using GameLibrary.DTOs;
using GameLibrary.Models;

namespace GameLibrary.Extensions;

public static class PlayerExtensions
{
    public static PlayerDto ToDto(this Player player) => new(player.Name, player.Level, player.JoinDate);
}
