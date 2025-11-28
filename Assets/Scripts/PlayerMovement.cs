using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
public class PlayerMovement : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField] float speed = 5;
    // this is the same as an Unreal public variable!

    PlayerInput playerInput;
    InputAction pMove;


    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        pMove = playerInput.actions.FindAction("Move");

    }

    void Update()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        Vector2 direction = pMove.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * speed * Time.deltaTime;

    }

}
