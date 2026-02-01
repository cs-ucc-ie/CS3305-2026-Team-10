using UnityEngine;
using System;
public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    public event Action OnInteractPressed;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;                  
    }
    void Update()
    {
        // use number key to change slot to choose item
        for (int i = 0; i < 5; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                Debug.Log("Key " + (i + 1) + " Pressed, selected slot is now " + i);
                InventoryManager.Instance.SetQuickSlotIndex(i);
            }
        }
        // press I to use item
        if (Input.GetKeyDown(KeyCode.I))
        {
            InventoryManager.Instance.UseSelectedQuickSlotItem();
        }
        // press E to interact
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interact logic should be here");
            OnInteractPressed?.Invoke();
        }
        
        // press ESC to toggle inventory ui
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UIController.Instance.ToggleFoldablePanel();
        }
        
        // lock or unlock mouse
        if (UIController.Instance.IsInventoryShown)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;                
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;        
        }
    }
}