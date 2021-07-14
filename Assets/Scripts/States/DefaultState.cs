using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultState : PlayerState
{
    
    public float walkSpeed;
    public float walkAccelleration;
    public float runSpeed;
    private float runMod;
    public float runAccelleration;

    public override void EnterState()
    {
        base.EnterState();
        CC.GetComponentInChildren<Animator>().Play("Locomotion", -1);
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void StateUpdate()
    {
        base.StateUpdate();
        if (Input.GetMouseButtonDown(0))
        {

            stateMachine.ChangeState(CharacterState.Attack);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            stateMachine.ChangeState(CharacterState.Dash);
        }
    }

    public override void StateFixedUpdate()
    {
        base.StateFixedUpdate();
        Vector2 inputDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (inputDirection.sqrMagnitude > 1) inputDirection.Normalize();
        if (inputDirection.sqrMagnitude < 0.1) inputDirection = Vector2.zero;
        runMod = (Input.GetKey(KeyCode.LeftShift))? 1.5f : 1f;
        Vector2 moveDirection = Vector2.Lerp(CC.velocity, inputDirection * walkSpeed * runMod, Time.deltaTime * walkAccelleration);
        CC.SetVelocity(moveDirection);

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
