# PlayerStatsManager

See [`PlayerStatsManager.cs`](../Assets/Scripts/GameManager/PlayerStatsManager.cs)

`PlayerStatsManager` is singleton and mounted on [`GameManager.md`](./GameManager.md).

`PlayerStatsManager` records player health, and provide methods to modify.

It also has methods to periodically reduce player hunger `TickHunger()` and when hunger is zero `TickStarve()`.

When data changed, events will be invoked:

- `OnPlayerHealthChanged` 
- `OnPlayerHungerChanged`
- `OnPlayerDied`