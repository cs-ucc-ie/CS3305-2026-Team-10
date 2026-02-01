# InteractableObject

See [`InteractableObject.cs`](../Assets/Scripts/InteractableObjects/InteractableObject.cs)

`InteractableObject` only containing one abstract method `Interact()`.

## Marking an Object as Interactable

Attach `InteractableObject` script to an GameObject.

## Check of an Interactable Object

See [`CheckInteractable.cs`](../Assets/Scripts/Player/CheckInteractable.cs)

If `InputManager` invoke an `OnInteractPressed`, then `CheckInteractable` will use raycast to detect whether object in front of player has `InteractableObject` game component. If yes, it will call it's `Interact()`.