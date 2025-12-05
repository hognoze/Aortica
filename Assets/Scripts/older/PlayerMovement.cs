using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.Tilemaps.Tilemap;
public class PlayerMovement : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField] float speed = 5;
    // this is the same as an Unreal public variable!

    PlayerInput playerInput;
    InputAction pMove;

    public Transform orientation;

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
