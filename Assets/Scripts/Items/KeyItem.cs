using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/Item/Key")]
public class KeyItem : Item
{
    private void OnEnable()
    {
        itemType = ItemType.Key;
    }

    public override bool Use()
    {
        // it's not the player to use the key to open door, 
        // but is the player to interact with door, 
        // and the door will automatically remove one key from inventory
        return false;
    }
}