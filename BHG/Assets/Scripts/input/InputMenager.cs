using UnityEngine;
using UnityEngine.InputSystem;

public class InputMenager : MonoBehaviour
{
    public static PlayerInput playerInput;

    public static Vector2 movement;
    public static bool jumpWasPressed;
    public static bool timeChangePastPressed;
    public static bool timeChangePresPressed;
    public static bool timeChangeFutuPressed;
    public static bool jumpWasReleased;

    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction timeFutuAction;
    private InputAction timePresAction;
    private InputAction timepastAction;
    

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        moveAction = playerInput.actions["Move"];
        jumpAction = playerInput.actions["Jump"];
        timeFutuAction = playerInput.actions["TimeChangeFutu"];
        timepastAction = playerInput.actions["TimeChangePast"];
        timePresAction = playerInput.actions["TimeChangePres"];
    }

    private void Update()
    {
        movement = moveAction.ReadValue<Vector2>();

        jumpWasPressed = jumpAction.WasPerformedThisFrame();
        timeChangeFutuPressed = timeFutuAction.WasPerformedThisFrame();
        timeChangePresPressed = timePresAction.WasPerformedThisFrame();
        timeChangePastPressed = timepastAction.WasPerformedThisFrame();
        jumpWasReleased = jumpAction.WasReleasedThisFrame();

    }
}
