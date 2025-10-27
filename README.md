# Game Library Project

## Overview

The **Game Library** project is a C# library designed to manage players, their statistics, inventory items, and game mechanics such as treasure chests. The project is structured to provide a clean and maintainable codebase, with clear separation of concerns between different components.

---

## Project Structure

### 1. **Models**
   - **`Player.cs`**: Represents a player in the game. It includes properties like `Name`, `Level`, `JoinDate`, and methods for managing the player's inventory and experience points.
   - **`PlayerDto.cs`**: A Data Transfer Object (DTO) for transferring simplified player information.
   - **`PlayerReportDto.cs`**: A DTO for generating player reports, including statistics like games played, total score, and average score.
   - **`PlayerStatistics.cs`**: Represents a player's statistics, including games played and total score.
   - **`InventoryItem.cs`**: Represents an item in the player's inventory, with properties like `Id`, `Name`, and `Description`.

### 2. **Services**
   - **`IPlayerStatisticsService.cs`**: An interface defining methods for retrieving and updating player statistics.
   - **`FileBasedPlayerStatisticsService.cs`**: An implementation of `IPlayerStatisticsService` that stores and retrieves player statistics from a JSON file.

### 3. **Game Logic**
   - **`GameWorld.cs`**: Manages the game world, including generating player reports and recording game wins.
   - **`TreasureChest.cs`**: Represents a treasure chest in the game, with logic to determine if it can be opened based on whether it is locked and if the player has a key.

### 4. **Extensions**
   - **`PlayerExtensions.cs`**: Contains extension methods for the `Player` class, such as converting a `Player` object to a `PlayerDto`.

---

## How It Works

### Player Management
- The `Player` class manages player information, including their level, inventory, and experience points.
- Players can increase their level, add items to their inventory, and gain experience points based on task difficulty and time taken.

### Player Statistics
- The `PlayerStatistics` class tracks player statistics such as games played and total score.
- The `FileBasedPlayerStatisticsService` class reads and writes player statistics to a JSON file, allowing for persistent storage.

### Game Mechanics
- The `GameWorld` class provides methods for generating player reports and recording game wins.
- The `TreasureChest` class manages the logic for opening treasure chests, depending on whether they are locked and if the player has a key.

---

## Unit Tests

The project includes a comprehensive suite of unit tests to ensure the correctness of the code. The tests are written using **Xunit**, **Moq**, **NSubstitute**, and **FluentAssertions**.

### Test Structure

#### 1. **Player Tests**
   - **`PlayerTests.cs`**: Tests for the `Player` class, including level increases, inventory management, and event handling.
   - **Examples**:
     - `IncreaseLevel_WhenCalled_HasExpectedLevel`: Ensures that the player's level increases correctly.
     - `AddItemToInventory_WithValidItem_AddsTheItem`: Verifies that items are correctly added to the player's inventory.

#### 2. **Player Extensions Tests**
   - **`PlayerExtensionsTests.cs`**: Tests for the `PlayerExtensions` class, ensuring that the `ToDto` method correctly maps a `Player` object to a `PlayerDto`.
   - **Example**:
     - `ToDto_WhenCalled_MapsProperties`: Verifies that the `ToDto` method correctly maps player properties.

#### 3. **GameWorld Tests**
   - **`GameWorldTests.cs`**: Tests for the `GameWorld` class, including player report generation and recording game wins.
   - **Examples**:
     - `GetPlayerReport_PlayerExists_ReturnsExpectedReport`: Ensures that the player report is generated correctly.
     - `RecordPlayerGameWin_ValidPlayerAndScore_UpdatesPlayerStatistics`: Verifies that player statistics are updated correctly after a game win.

#### 4. **GameWorld Moq Tests**
   - **`GameWorldMoqTests.cs`**: Similar to `GameWorldTests`, but uses **Moq** for mocking dependencies.
   - **Examples**:
     - `GetPlayerReport_PlayerExists_ReturnsExpectedReport`: Ensures that the player report is generated correctly using Moq.
     - `RecordPlayerGameWin_ValidPlayerAndScore_UpdatesPlayerStatistics`: Verifies that player statistics are updated correctly using Moq.

#### 5. **Treasure Chest Tests**
   - **`TreasureChestTests.cs`**: Tests for the `TreasureChest` class, ensuring that the chest can be opened under the correct conditions.
   - **Examples**:
     - `CanOpen_WhenCalled_ReturnsExpectedOutcome`: Tests various scenarios for opening a treasure chest based on whether it is locked and if the player has a key.

#### 6. **Fake Player Statistics Service**
   - **`FakePlayerStatisticsService.cs`**: A fake implementation of `IPlayerStatisticsService` used in tests to avoid dependencies on external systems.

---

## Running the Tests

To run the tests, use the following command in the terminal:

```powershell
dotnet test
```

---

## Conclusion

The **Game Library** project is a well-structured C# library for managing players, their statistics, and game mechanics. The accompanying unit tests ensure that the code is reliable and maintainable. This project serves as a great example of how to structure a C# project and write comprehensive unit tests.