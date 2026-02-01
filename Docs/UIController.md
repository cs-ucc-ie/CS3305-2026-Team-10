# UIController

See [`UIController.cs`](../Assets/Scripts/UI/UIController.cs)

`UIController` maintains all UI elements, including:

- Bottom panel displaying player stats and quick select slots
- Inventory displaying the full inventory
- Also updates UI fold / unfold animation

## Generation of Inventory Slots

`UIController` instantiates InventorySlot prefabs as children of a GameObject containing a GridLayoutGroup.