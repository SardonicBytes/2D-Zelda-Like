using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashState : PlayerState
{

    public float attackMoveBoost;
    private Vector2 direction;
    public float duration;

    public override void EnterState()
    {
        base.EnterState();
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        Invoke("End",duration);
    }

    void End()
    {
        stateMachine.ChangeState(CharacterState.Default);
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void StateUpdate()
    {
        base.StateUpdate();
    }

    public override void StateFixedUpdate()
    {
        base.StateFixedUpdate();
        CC.SetVelocity(direction * attackMoveBoost);
    }

    public override void OnEquip(PlayerStateMachine newStateMachine)
    {
        base.OnEquip(newStateMachine);
    }

    public override void OnUnequip()
    {
        base.OnUnequip();
    }

    public override void OnAnimationEnd()
    {
        base.OnAnimationEnd();
    }

    public override void OnAnimationEvent()
    {
        base.OnAnimationEvent();
    }
}
