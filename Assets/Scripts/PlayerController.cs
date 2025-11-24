using System;
using UnityEngine;
using UnityEngine.InputSystem;
// ReSharper disable Unity.InefficientMultiplicationOrder

[DefaultExecutionOrder(-1)]
public class PlayerController : MonoBehaviour
{
    #region Class Variables
    
    [Header("Components")]
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Camera playerCamera;
    
    [Header("Movement Settings")]
    public float runAcceleration = 0.25f;
    public float runSpeed = 4f;
    public float drag = 0.1f;
    public float gravity = -9.81f;
    public float jumpSpeed = 8.0f;
    public float movingThreshold = 0.01f;

    [Header("Camera Settings")] 
    public float lookSenseH = 1f;
    public float lookSenseV = 1f;
    public float lookLimitV = 89f;
    
    
    private PlayerLocomotionInput _playerLocomotionInput;
    private Vector2 _cameraRotation = Vector2.zero;
    private Vector2 _playerTargetRotation = Vector2.zero;
    private float _verticalVelocity = 0f;
    private PlayerState _playerState;
    

    #endregion

    #region Startup
    private void Awake()
    {
        _playerLocomotionInput = GetComponent<PlayerLocomotionInput>();
        _playerState = GetComponent<PlayerState>();
    }
    
    void Start()
    {
        
    }
    #endregion

    #region Update Logic
    
    void Update()
    {
        HandleMovement();
    }  

    private void HandleMovement()
    {
        UpdateMovementState();
        HandleVerticalMovement();
        HandleGroundedMovement();
    }


    private void HandleGroundedMovement()
    {
        bool isGrounded = _playerState.InGroundedState();
        
        Vector3 cameraForwardXZ = new Vector3(playerCamera.transform.forward.x, 0f, playerCamera.transform.forward.z).normalized;
        Vector3 cameraRightXZ = new Vector3(playerCamera.transform.right.x, 0f, playerCamera.transform.right.z).normalized;
        Vector3 movementDirection = cameraRightXZ * _playerLocomotionInput.MovementInput.x + cameraForwardXZ * _playerLocomotionInput.MovementInput.y; 
        
        Vector3 movementDelta = movementDirection * runAcceleration * Time.deltaTime;
        Vector3 newVelocity = characterController.velocity + movementDelta;

        Vector3 currentDrag = newVelocity.normalized * drag * Time.deltaTime;
        newVelocity = (newVelocity.magnitude > drag * Time.deltaTime) ? newVelocity - currentDrag : Vector3.zero;
        newVelocity = Vector3.ClampMagnitude(newVelocity, runSpeed);
        newVelocity.y += _verticalVelocity;
        characterController.Move(newVelocity * Time.deltaTime);
    }


    private void HandleVerticalMovement()
    {
        bool isGrounded = _playerState.InGroundedState();

        if (_verticalVelocity < 0 && isGrounded)
        {
            _verticalVelocity = 0f;

        }
        
        _verticalVelocity += gravity * Time.deltaTime;

        if (_playerLocomotionInput.JumpPressed && isGrounded)
        {
            _verticalVelocity += Mathf.Sqrt(jumpSpeed * -3f * gravity);
        }
    }
    
    private void UpdateMovementState()
    {
        bool isMovementInput = _playerLocomotionInput.MovementInput != Vector2.zero;
        bool isHorizontalMovement = HorizontalMovementCheck();
        bool isGrounded = GroundCheck();
        
        PlayerMovementState lateralState = isHorizontalMovement || isMovementInput ? PlayerMovementState.Moving : PlayerMovementState.Idling;
        _playerState.SetPlayerMovementState(lateralState);

        if (!isGrounded && characterController.velocity.y > 0f)
        {
            _playerState.SetPlayerMovementState(PlayerMovementState.Jumping);
        }
        else if (!isGrounded && characterController.velocity.y <= 0f)
        {
            _playerState.SetPlayerMovementState(PlayerMovementState.Falling);
        }
    }
    
    #endregion

    #region Late Update Logic

    private void LateUpdate()
    {
        RotateCamera();
    }

    
    private void RotateCamera()
    {
        _cameraRotation.x += lookSenseH * _playerLocomotionInput.LookInput.x;
        _cameraRotation.y = Mathf.Clamp(_cameraRotation.y - lookSenseV *  _playerLocomotionInput.LookInput.y, -lookLimitV, lookLimitV);
        
        _playerTargetRotation.x += transform.eulerAngles.x + lookSenseH * _playerLocomotionInput.LookInput.x;  
        transform.rotation = Quaternion.Euler(0f, _playerTargetRotation.x, 0f);
        
        playerCamera.transform.rotation = Quaternion.Euler(_cameraRotation.y, _cameraRotation.x, 0f);
    }
    #endregion

    #region State Checks

    private bool HorizontalMovementCheck()
    {
        Vector3 horizontalVelocity = new Vector3(characterController.velocity.x, 0f, characterController.velocity.y);
        
        return horizontalVelocity.magnitude > movingThreshold;
    }

    private bool GroundCheck()
    {
        return characterController.isGrounded;
    }

    private bool AttackCheck()
    {
        return _playerLocomotionInput.AttackPressed;
    }
    
    #endregion

}
