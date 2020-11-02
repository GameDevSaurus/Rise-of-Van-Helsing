using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSpecificController : SpecificEnemyBehaviour
{

    float _currentHitElapsedTime;
    [SerializeField]
    float _attackTime;
    [SerializeField]
    float _currentAttackElapsedTime;
    [SerializeField]
    float _hitTime;
    [SerializeField]
    float _currentSpeed;
    [SerializeField]
    float _chaseSpeed;
    bool _waitingForAttack;
    public override void Attack()
    {
        _animatorController.Attack();
        _waitingForAttack = true;
    }

    public override void Die()
    {
         //_enemyController.GetBloodExplosionPool().Play(transform.position);
        Destroy(transform.root.gameObject);
    }

    public override void Appear()
    {
        print("Mursiégalo aparisión");
    }

    public override void Init()
    {
        _currentHitElapsedTime = _hitTime;
        _currentAttackElapsedTime = _attackTime;
        _animatorController.Init();
        _bezierWalker.SetOnlyRotate(true);
        Move();
    }
    public override void Dissolve()
    {
        print("Mursiégalo Dissolve");
    }
    public override void Taunt()
    {
        print("Mursiégalo Taunteo");
    }
    public override void Move()
    {
        _currentState = EnemyStates.Chasing;
        StartCoroutine(CoMove());
    }

    IEnumerator CoMove()
    {
        
        yield return StartCoroutine(_bezierWalker.CoMoveFullPath());
        _currentState = EnemyStates.Fighting;
    }

    public override void ReceiveHit()
    {
        if(_currentHitElapsedTime >= _hitTime)
        {
            _currentHitElapsedTime = 0;
            switch (_currentState)
            {
                case EnemyStates.Chasing:
                    _currentSpeed = 0;
                    _animatorController.GetHit();
                    break;
                case EnemyStates.Fighting:
                    _animatorController.GetHit();
                    break;
            }
            
        }
    }

    public override void SetSkin(int skin)
    {
    }

    public void Update()
    {
        _currentHitElapsedTime += Time.deltaTime;
        _currentAttackElapsedTime += Time.deltaTime;
        _bezierWalker.SetSpeed(_currentSpeed * CurrentSceneController._currentGameSpeed);

        switch (_currentState)
        {
            case EnemyStates.Dead:

                break;
            case EnemyStates.Fighting:
                if(_currentAttackElapsedTime >= _attackTime)
                {
                    _currentAttackElapsedTime = 0;
                    Attack();
                }
                break;
        }
    }

    public override void SetSpeed(float speed)
    {
        _currentSpeed = speed;
        _chaseSpeed = speed;
    }
    public override void Orient()
    {
        _bezierWalker.Orient();
    }
    public override void RCOrient()
    {
        _bezierWalker.RCOrient();
    }
    public override void AttackDamageCallback()
    {
        _waitingForAttack = false;
        _enemyController.AttackPlayer();
    }
    public override void AttackDamageCallback(EnemyAttackTypes attackType, EnemyAttackParts attackPart, EnemyAttackDirections attackDirections)
    {
        _waitingForAttack = false;
        if(attackType== EnemyAttackTypes.Hit)
        {
            _enemyController.AttackPlayer();
        }
        else
        {
            _enemyController.AttackPlayer(attackType, attackPart, attackDirections);
        }
    }
    public override void HitReturnCallback()
    {
        switch (_currentState)
        {
            case EnemyStates.Fighting:
                if (_waitingForAttack)
                {
                    _currentAttackElapsedTime = _attackTime;
                    _animatorController.Attack();
                }
                else
                {
                    _animatorController.GoIdle();
                }
                break;

            case EnemyStates.Chasing:
                _currentSpeed = _chaseSpeed;
                _animatorController.Chase();
                break;
        }
    }
    public override void AttackReturnCallback()
    {
        _animatorController.GoIdle();
    }

    public override void DieByExplosion(Vector3 explosionOrigin)
    {
        throw new System.NotImplementedException();
    }

    public override void DieByKnife(Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public override void Die(Rigidbody rigidbody, Vector3 direction)
    {
        throw new System.NotImplementedException();
    }

}
