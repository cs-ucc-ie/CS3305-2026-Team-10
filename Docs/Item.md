# Item

See [`Item.cs`](../Assets/Scripts/Items/Item.cs)

Defines the data template for a game Item as a `ScriptableObject`.

This class holds raw data only and does not contain game logic.

`Item` has several enum types, e.g. seed, food, material, etc.

## Creation of an Item

To create a new item, right-click in the assets window and go to [Create -> Inventory -> Item].

## Logic of Item Usage

The `Item` only contains an virtual method `Use()`.

Specific usage of a type of item is under [Item](../Assets/Scripts/Items/). 

For example, item of food type is defined by [`FoodItem.cs`](../Assets/Scripts/Items/FoodItem.cs). The script specifies that when calling `Use()` on `FoodItem`, it will try to increase player health.

If an item is used successfully, the Use() method should return true to trigger a count reduction of 1 in `InventoryManager`.

## Item Storage

For the logic that handles these items, see [`InventoryManager.md`](./InventoryManager.md).

