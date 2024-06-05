using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public PlayerInput playerInput;

    
    // WASD ile hareket new input system kullanarak hareket
    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.Player.Enable();
    }
    public Vector3 GetMovementInput()
    {
        Vector2 movementInput = playerInput.Player.Move.ReadValue<Vector2>();
        return new Vector3(movementInput.x, 0.0f, movementInput.y);
    }

}