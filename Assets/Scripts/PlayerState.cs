using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected Controller CC;
    [SerializeField]
    protected string stateName;

    public float animationStateName;

    public bool IsActive { get; private set; }

    public virtual void EnterState()
    {
        IsActive = true;
    }

    public virtual void ExitState()
    {
        IsActive = false;
    }

    public virtual void Update()
    {

    }

    public virtual void FixedUpdate()
    {

    }

    public virtual void OnEquip()
    {

    }

    public virtual void OnUnequip()
    {

    }

    public virtual void OnAnimationEnd()
    {

    }

    public virtual void OnAnimationEvent()
    {

    }

}
