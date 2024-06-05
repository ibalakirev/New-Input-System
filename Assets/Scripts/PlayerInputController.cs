using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();

        _playerInput.Player.Shoot.performed += OnShoot;
        _playerInput.Player.Move.performed += OnMove;
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        Debug.Log("Shoot");
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveDirection = context.action.ReadValue<Vector2>();

        Debug.Log(moveDirection);
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }
}
