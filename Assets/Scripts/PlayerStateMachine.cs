using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public struct SerializableState
    {
        public CharacterState characterState;
        public PlayerState playerState;
    }
    [SerializeField]
    public SerializableState[] serializableStates;


    public PlayerState CurrentState { get; private set; }
    [SerializeField]
    public Dictionary<CharacterState, PlayerState> characterStates = new Dictionary<CharacterState, PlayerState>();
    

    public PlayerStateMachine(CharacterState startingState, GameObject gameObject)
    {

        PlayerState[] allStates = gameObject.GetComponents<PlayerState>();
        
        for (int i = 0; i < allStates.Length; i++)
        {
            characterStates.Add(allStates[i].stateType, allStates[i]);
            allStates[i].OnEquip(this);
        }
        CurrentState = characterStates[startingState];
        CurrentState.EnterState();
    }

    public void ChangeState(CharacterState newState)
    {
        CurrentState.ExitState();
        CurrentState = characterStates[newState];
        CurrentState.EnterState();
    }

    public virtual void StateUpdate()
    {
        CurrentState.StateUpdate();
    }

    public virtual void StateFixedUpdate()
    {
        CurrentState.StateFixedUpdate();
    }

}


