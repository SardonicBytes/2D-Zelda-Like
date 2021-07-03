using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    [SerializeField]
    public PlayerState idleState;
    public PlayerState walkState;
    public PlayerState runState;
    public PlayerState jumpUpState;
    public PlayerState fallState;
    public PlayerState slideState;

    public PlayerState CurrentState { get; private set; }
    public Dictionary<CharacterState, PlayerState> characterStates = new Dictionary<CharacterState, PlayerState>();
    

    public PlayerStateMachine(PlayerState startingState)
    {
        CurrentState = startingState;
        CurrentState.EnterState();
        characterStates.Add(CharacterState.Idle, idleState);
    }

    public void ChangeState(CharacterState newState)
    {
        CurrentState.ExitState();
        CurrentState = characterStates[newState];
        CurrentState.EnterState();
    }

    public void Update()
    {
        CurrentState.Update();
    }

    public void FixedUpdate()
    {
        CurrentState.Update();
    }

}

public enum CharacterState { Idle, JumpStart, Jumping, Falling, Sliding, Running, LightHurt, Hardhurt, Dying }
