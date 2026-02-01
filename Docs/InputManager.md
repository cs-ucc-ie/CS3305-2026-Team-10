# InputManager

See [`InputManager.cs`](../Assets/Scripts/GameManager/InputManager.cs)

`InputManager` is singleton and mounted on [`GameManager.md`](./GameManager.md).

`InputManager` handles player inputs, and dynamically lock / unlock user cursor depending on whether inventory UI is shown or not.

It handles:

- WASD for record movement, see [`Player.md`](./Player.md).
- Mouse movement for record rotation, see [`Player.md`](./Player.md).
- 1, 2, 3, 4, 5 for selecting quick slot, see [`InventoryManager.md`](./InventoryManager.md).
- I for using selected quick slot, see [`InventoryManager.md`](./InventoryManager.md).
- E for interact with object, see [`Player.md`](./Player.md).
- 