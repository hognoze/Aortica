using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

[RequireComponent(typeof(CharacterController), typeof(PlayerInput))]
//this script will only work if the object has a CC and PI 

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 5.0f;
    [SerializeField]
    private float gravityValue = -9.81f;

    public CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;


    public InputActionReference moveAction;
    public InputActionReference aimAction;
    public InputActionReference sprintAction;
    public InputActionReference attackAction;
    public InputActionReference interactAction;


    private void OnEnable()
    {
        moveAction.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
    }

    // to toggle movement, e.g. if entering a pause menu

    void Update()
    {
        groundedPlayer = controller.isGrounded;

        if (groundedPlayer)
        {
            if (playerVelocity.y < -2f)
                playerVelocity.y = -2f;
        }
    // gravity!


        Vector2 input = moveAction.action.ReadValue<Vector2>();
        Vector3 move = new Vector3(input.x, 0, input.y);
        move = Vector3.ClampMagnitude(move, 1f);
    // use the vec2 to create a new vec3 where vertical movement it locked to 0 (change for jumping)

        if (move != Vector3.zero)
            transform.forward = move;
    // move based on facing direction
    
        Vector3 finalMove = move * playerSpeed + Vector3.up * playerVelocity.y;
        controller.Move(finalMove * Time.deltaTime);
    // final execution that takes into account the custom speed variable


    }
}