# GameManager

See [`GameManager.cs`](../Assets/Scripts/GameManager/GameManager.cs)

The `GameManager` is a persistent entry point. Using `DontDestroyOnLoad`, it ensures that all attached child systems persist across scene transitions.

Both GameManager and attached scripts should be singleton.

Currently three scripts should be attached under `GameManager` objects.

- [`InventoryManager.md`](./InventoryManager.md)
- [`InputManager.md`](./InputManager.md)
- [`PlayerStatsManager.md`](./PlayerStatsManager.md)