using System;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [field: SerializeField] public PlayerMovementState CurrentPlayerMovementState { get; private set; } =  PlayerMovementState.Idling;

    public void SetPlayerMovementState(PlayerMovementState newPlayerMovementState)
    {
        CurrentPlayerMovementState = newPlayerMovementState;
    }

    public bool InGroundedState()
    {
        return CurrentPlayerMovementState is PlayerMovementState.Moving or PlayerMovementState.Idling;
    }
    
    public string StringRepresentation()
    {
        string str = "";
        
        switch (CurrentPlayerMovementState)
        {
            case PlayerMovementState.Idling:
                str = "Idling";
                break;
            case PlayerMovementState.Moving:
                str = "Moving";
                break;
            case PlayerMovementState.Jumping:
                str = "Jumping";
                break;
            case PlayerMovementState.Falling:
                str = "Falling";
                break;
            case PlayerMovementState.Attacking:
                str = "Attacking";
                break;
        }
        
        return str;
    }
}

public enum PlayerMovementState
{
    Idling = 0,
    Moving = 1,
    Jumping = 2,
    Falling = 3,
    Attacking = 4,
}