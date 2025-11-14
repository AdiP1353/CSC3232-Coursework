using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    private CharacterController characterController;

    [Header("Movement Settings")]
    [SerializeField] private float walkSpeed = 5f;


    [Header("Input")]
    private float moveInput;
    private float turnInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManager();
        Movement();
    }


    private void Movement()
    {
        GroundMovement();
    }

    private void GroundMovement()
    {
        Vector3 move  = new Vector3(turnInput, 0, moveInput).normalized;

        move.y = 0;
        move *= walkSpeed;

        characterController.Move(move * Time.deltaTime);
    }
    private void InputManager()
    {
        moveInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }
}
