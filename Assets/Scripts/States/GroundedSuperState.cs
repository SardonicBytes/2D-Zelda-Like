using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedSuperState : PlayerState
{

    public override void EnterState()
    {
        base.EnterState();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void Update()
    {

    }

    public override void FixedUpdate()
    {
        if (CC.IsGrounded)
        {
            stateMachine.ChangeState(CharacterState.Idle);
        }
    }

    public override void OnEquip()
    {

    }

    public override void OnUnequip()
    {

    }

    public override void OnAnimationEnd()
    {

    }

    public override void OnAnimationEvent()
    {

    }

}
