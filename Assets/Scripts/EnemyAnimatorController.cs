using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorController : MonoBehaviour
{
    [SerializeField]
    public Animator animator;
    public EnemyController mainController;
    public SpecificEnemyBehaviour _specificBehaviour;
    EnemyAttackParts _currentAttackPart;
    EnemyAttackTypes _currentAttackType;
    EnemyAttackDirections _currentAttackDirection;
    float _chaseSpeedMultiplier;
    public void SetIdleSpeed(float speed)
    {
        animator.SetFloat("IdleSpeed", speed);
    }
    float _chaseIndex;
    public void Chase()
    {
        animator.SetTrigger("Chase");
    }
    public void SetChaseAnimatorSpeedOffset(float animatorSpeedOffset)
    {
        _chaseSpeedMultiplier = animatorSpeedOffset;

    }
    public void SetAttackPart(EnemyAttackParts ap)
    {
        _currentAttackPart = ap;
    }

    public void SetAttackDirection(EnemyAttackDirections ad)
    {
        _currentAttackDirection = ad;
    }
    public void SetAttackType(EnemyAttackTypes at)
    {
        _currentAttackType = at;
    }
    public void AttackDamageCallback()
    {

        _specificBehaviour.AttackDamageCallback(_currentAttackType, _currentAttackPart, _currentAttackDirection);
        /*
        if(mainController.type == EnemySpawner.EnemyType.Spitter)
        {
            mainController.ThrowGoo();
        }
        else
        {
            if(mainController.type == EnemySpawner.EnemyType.Bat)
            {
                mainController.AttackPlayer();
            }
            else
            {
                mainController.AttackPlayer(_currentAttackType, _currentAttackPart, _currentAttackDirection);
            }
        }*/

    }
    public void Attack()
    {
        animator.SetFloat("AttackIndex", Random.Range(0, 2));
        animator.SetTrigger("Attack");
    }
    public virtual void BattleIdle()
    {
        animator.SetFloat("IdleIndex", 0);
        animator.SetTrigger("Idle");
    }
    public void GoIdle()
    {
        animator.SetFloat("IdleIndex", Random.Range(0, 2));
        animator.SetTrigger("Idle");
    }
    public void Die(bool headshoot)
    {
        if (headshoot)
        {
            animator.SetFloat("DeadIndex", 1);
        }
        animator.SetTrigger("Die");
    }
    public void Taunt()
    {
        animator.SetTrigger("Taunt");
    }
    public void GetHit()
    {
        animator.SetTrigger("Damaged");
    }
    public void HitReturnCallback()
    {
        _specificBehaviour.HitReturnCallback();
    }
    public void AttackReturnCallback()
    {
        _specificBehaviour.AttackReturnCallback();
    }
    public void SetChaseIndex(int chaseIndex)
    {
        _chaseIndex = (float)chaseIndex;
    }

    public void Init()
    {
        animator.SetFloat("ChaseIndex", _chaseIndex);
        animator.SetFloat("ChaseSpeedMultiplier", _chaseSpeedMultiplier);

    }

    void Update()
    {
        animator.speed = CurrentSceneController._currentGameSpeed;
    }
    public void Explode()
    {
        //mainController.Explode();
    }
}
