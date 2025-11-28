using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-2)]
public class PlayerLocomotionInput : MonoBehaviour, PlayerControls.IPlayerActions
{
    #region Class Variables
    public PlayerControls PlayerControls { get; private set;}
    public Vector2 MovementInput { get; private set;}
    
    public Vector2 LookInput { get; private set;}

    
    public bool JumpPressed { get; private set;}
    
    public bool AttackPressed  { get; private set;}
    
    

    #endregion
    
    #region Startup 
    private void OnEnable()
    {
        PlayerControls = new PlayerControls();
        PlayerControls.Enable();

        PlayerControls.Player.Enable();
        PlayerControls.Player.SetCallbacks(this);
    }
    
    void Start()
    {
        
    }
    #endregion

    #region Late Update Logic

    void LateUpdate()
    {
        JumpPressed = false;
        AttackPressed = false;
    }


    #endregion

    #region Input Callbacks

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementInput =  context.ReadValue<Vector2>(); 
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        LookInput = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (!context.performed)
        {
            return;
        }
        
        AttackPressed = true;
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        ;
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
        ;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (!context.performed)
        {
            return;
        }
        
        JumpPressed = true;
    }

    public void OnPrevious(InputAction.CallbackContext context)
    {
        ;
    }

    public void OnNext(InputAction.CallbackContext context)
    {
        ;
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        ;
    }

    #endregion


}
