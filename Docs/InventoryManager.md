# InventoryManager

See [`InventoryManager.cs`](../Assets/Scripts/GameManager/InventoryManager.cs)

`InventoryManager` maintains player inventory.

It use `List<InventorySlot>` to store all slots.

It also has a `List<InventorySlot>` containing 5 quick slots (for UI quick select usage), and a index pointing to selected quick slot.

## InventorySlot

See [`InventoryManager.cs`](../Assets/Scripts/GameManager/InventoryManager.cs)

Each inventory slot contains an `Item` and a count. It also contains a `Use()` method, which will call `Item.Use()`.

## Item Usage Logic

To use an item, first the slot should be in one of 5 of the quick slots. Next, change quick slot index to the slot, and call `UseSelectedQuickSlotItem()`

If `Item.Use()` returned true, then item is successfully used. So `InventoryManager` will reduce item count. And, if count is zero, this `InventorySlot` will be removed from list.

## Events

When all slots or quick slots has changed i.e. change of item type or count, an `OnInventoryChanged` / `OnQuickSlotsChanged` event will be invoke.

When index of quick slot has changed, an `OnQuickSlotIndexChanged` event will be invoke.
