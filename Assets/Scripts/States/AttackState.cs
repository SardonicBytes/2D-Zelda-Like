using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : PlayerState
{

    public GameObject weaponCoverObject;
    protected SpriteRenderer weaponCoverSpriteRenderer;
    protected Animator weaponCoverAnimator;

    public GameObject weaponObject;
    protected SpriteRenderer weaponSpriteRenderer;
    protected Animator weaponAnimator;

    public float resetFrame;
    public float hitFrame;
    public Attack attack;

    public float attackMoveBoost;
    public float deccelleration;

    public override void EnterState()
    {
        base.EnterState();


        //Vector2 inputDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        Vector2 inputDirection = CC.velocity.normalized;
        CC.SetVelocity(inputDirection * attackMoveBoost);


        weaponSpriteRenderer.enabled = true;
        weaponCoverSpriteRenderer.enabled = true;
        float direction = (float)character.facing.ToInt();
        anim.SetFloat("Direction", direction);
        weaponAnimator.SetFloat("Direction", direction );
        weaponCoverAnimator.SetFloat("Direction", direction);
        anim.Play("Attack1",-1);
        weaponAnimator.Play("Attack1", -1);
        weaponCoverAnimator.Play("Attack1", -1);

        StartCoroutine(DelayedHit());


        weaponCoverSpriteRenderer.flipX = (character.facing == FaceDirection.East || character.facing == FaceDirection.NorthEast || character.facing == FaceDirection.SouthEast);
        weaponSpriteRenderer.flipX = (character.facing == FaceDirection.East || character.facing == FaceDirection.NorthEast || character.facing == FaceDirection.SouthEast);
        

    }

    public override void ExitState()
    {
        base.ExitState();
        weaponSpriteRenderer.enabled = false;
        weaponCoverSpriteRenderer.enabled = false;
    }

    public override void StateUpdate()
    {
        base.StateUpdate();
    }

    public override void StateFixedUpdate()
    {
        base.StateFixedUpdate();
        Vector2 moveDirection = Vector2.Lerp(CC.velocity, Vector2.zero, Time.deltaTime * deccelleration);
        CC.SetVelocity(moveDirection);
    }

    public override void OnEquip(PlayerStateMachine newStateMachine)
    {
        base.OnEquip(newStateMachine);
        weaponCoverSpriteRenderer = weaponObject.GetComponent<SpriteRenderer>();
        weaponSpriteRenderer = weaponCoverObject.GetComponent<SpriteRenderer>();
        weaponAnimator = weaponObject.GetComponent<Animator>();
        weaponCoverAnimator = weaponCoverObject.GetComponent<Animator>();
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

    public IEnumerator DelayedHit()
    {
        yield return new WaitForSeconds(hitFrame);
        DoAttack();
        yield return new WaitForSeconds(resetFrame);
        stateMachine.ChangeState(CharacterState.Default);
    }

    public void DoAttack()
    {
        //Debug.Log("Attack Hit Frame");
    }

}
