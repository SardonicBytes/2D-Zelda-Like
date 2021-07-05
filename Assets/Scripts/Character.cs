using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterState startingState;
    PlayerState[] CharacterStates;
    public CharacterState currentState;

    protected Stats stats;
    protected Status status;
    protected PlayerStateMachine stateMachine;
    protected Animator anim;
    protected Controller CC;

    public float rotationThreshold;
    protected FaceDirection facing;

    public DirectionStyle directionStyle;

    private void Start()
    {
        CC = GetComponent<Controller>();
        stateMachine = new PlayerStateMachine(startingState, gameObject);
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        stateMachine.StateUpdate();
        AnimationHandling();
        currentState = stateMachine.CurrentState.stateType;
        
    }

    private void FixedUpdate()
    {
        stateMachine.StateFixedUpdate();
    }


    private void AnimationHandling()
    {
        if (CC.velocity.sqrMagnitude > rotationThreshold)
        {
            int faceDirection;

            //anim.SetInteger("FaceDirection", faceDirection );
        }
    }


}

public enum FaceDirection { North, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest };
public enum DirectionStyle { Locked, TwoWay, FourWay, EightWay, Unlocked };
