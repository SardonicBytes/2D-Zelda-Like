using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerState : MonoBehaviour
{
    public CharacterState stateType;
    protected PlayerStateMachine stateMachine;
    protected Controller CC;
    protected Animator anim;
    protected Character character;

    public string animationStateName;

    public bool IsActive { get; private set; }

    public virtual void EnterState()
    {
        IsActive = true;
    }

    public virtual void ExitState()
    {
        IsActive = false;
    }

    public virtual void StateUpdate()
    {

    }

    public virtual void StateFixedUpdate()
    {

    }

    public virtual void OnEquip( PlayerStateMachine newStateMachine)
    {
        CC = GetComponent<Controller>();
        character = CC.character;
        anim = character.anim;
        stateMachine = newStateMachine;
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
