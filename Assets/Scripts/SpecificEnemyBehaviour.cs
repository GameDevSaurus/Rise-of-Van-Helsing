using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpecificEnemyBehaviour : MonoBehaviour
{

    public EnemyAnimatorController _animatorController;
    public BezierWalker _bezierWalker;
    public EnemyController _enemyController;
    public EnemyStates _currentState;

    public abstract void DieByExplosion(Vector3 explosionOrigin);
    public abstract void DieByKnife(Vector3 position);
    public void SetPath(BezierSpline bezierSpline)
    {
        _bezierWalker.SetPath(bezierSpline);
    }
    public void SetChaseIndex(int index)
    {
        _animatorController.SetChaseIndex(index);
    }
    public void SetChaseAnimationSpeedOffset(float chaseAnimationSpeedOffset)
    {
        _animatorController.SetChaseAnimatorSpeedOffset(chaseAnimationSpeedOffset);
    }
    public abstract void Init();

    public abstract void Attack();

    public abstract void ReceiveHit();

    public abstract void Move();

    public abstract void Die(Rigidbody rigidbody, Vector3 direction);
    public abstract void Die();
    public abstract void SetSkin(int skin);

    public abstract void Taunt();

    public abstract void Dissolve();

    public abstract void Appear();

    public abstract void SetSpeed(float speed);
    public abstract void AttackDamageCallback();
    public abstract void AttackDamageCallback(EnemyAttackTypes attackType, EnemyAttackParts attackPart, EnemyAttackDirections attackDirections);
    public abstract void AttackReturnCallback();
    public abstract void HitReturnCallback();
    public abstract void Orient();
    public abstract void RCOrient();
}
