using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class KeyboardMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float gravity = -9.8f;
    private CharacterController _charController;
    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (InputManager.Instance == null) return;
        Vector2 input = InputManager.Instance.MoveInput;
        float deltaX = input.x * speed;
        float deltaZ = input.y * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
    }
}
