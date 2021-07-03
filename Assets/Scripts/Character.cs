using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public PlayerState startingState;

    Stats stats;
    Status status;
    PlayerStateMachine stateMachine;
    Animator anim;
    Controller CC;

    private void Start()
    {
        CC = GetComponent<Controller>();
        stateMachine = new PlayerStateMachine(startingState);
        anim = GetComponent<Animator>();
        if(startingState != null)startingState = stateMachine.idleState;

    }

    private void Update()
    {
        stateMachine.Update();
        AnimationHandling();
    }

    private void FixedUpdate()
    {
        stateMachine.FixedUpdate();
    }


    private void AnimationHandling()
    {

    }


}
