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
    public FaceDirection facing;

    public DirectionStyle directionStyle;

    private void Start()
    {
        CC = GetComponent<Controller>();
        stateMachine = new PlayerStateMachine(startingState, gameObject);
        anim = GetComponentInChildren<Animator>();

    }

    private void Update()
    {
        stateMachine.StateUpdate();
        AnimationHandling();
        currentState = stateMachine.CurrentState.stateType;
        
    }
    public Vector2 Velocity;
    private void FixedUpdate()
    {
        stateMachine.StateFixedUpdate();
        Velocity = CC.velocity;
    }


    private void AnimationHandling()
    {
        if (CC.velocity.sqrMagnitude > rotationThreshold)
        {
            facing = CC.velocity.ToCardinalSmoothed(facing, 0f, directionStyle);
            //facing = CC.velocity.ToC
            //facing = Velocity.ToAngle
            anim.SetInteger("Direction", facing.ToInt() );
        }
    }


}

public enum FaceDirection { North, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest };
public enum DirectionStyle { Locked, TwoWay, FourWay, EightWay, Unlocked };
