using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCopyState : PlayerState
{
    public override void EnterState()
    {
        base.EnterState();
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
