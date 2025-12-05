using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerInputs controls;
    PlayerInputs.IPlayerMovementActions actions;

    private void Start()
    {
        controls = new PlayerInputs();
        //actions = controls.actions;

    }
}
