﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveSpecificController : SpecificEnemyBehaviour
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
    VFXPool _embersPool;
    [SerializeField]
    SkinnedMeshRenderer[] skinnedMeshRenderers;
    [SerializeField]
    float _tauntTime;
    public override void RCOrient()
    {
        _bezierWalker.RCOrient();
    }
    public override void Attack()
    {
        _animatorController.Attack();
        _waitingForAttack = true;
    }
    public override void AttackDamageCallback(EnemyAttackTypes attackType, EnemyAttackParts attackPart, EnemyAttackDirections attackDirections)
    {
        _waitingForAttack = false;
        _enemyController.AttackPlayer(attackType, attackPart, attackDirections);
    }
    
    public override void Die()
    {
        if (_currentState != EnemyStates.Dead)
        {
            foreach (Collider c in GetComponentsInChildren<Collider>(true))
            {
                c.enabled = false;
            }
            _animatorController.Die(false);
            _currentState = EnemyStates.Dead;
            _currentSpeed = 0;
            //Dissolve();
        }
    }
    public override void Orient()
    {
        _bezierWalker.Orient();
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
        //if (_enemyController.GetStartTaunt())
        //{
        //    _bezierWalker.Orient();
        //    Taunt();
        //}
        //else
        //{
        //}
        Move();

    }
    public override void Dissolve()
    {
        StartCoroutine(CoDissolve());
    }
    public override void Taunt()
    {
        StartCoroutine(CoTaunt());
    }
    IEnumerator CoTaunt()
    {
        _animatorController.Taunt();
        yield return new WaitForSeconds(_tauntTime);
        Move();
    }
    public override void Move()
    {
        _currentState = EnemyStates.Chasing;
        _animatorController.Chase();
        StartCoroutine(CoMove());
    }

    IEnumerator CoMove()
    {

        yield return StartCoroutine(_bezierWalker.CoMoveFullPath());
        _currentState = EnemyStates.Fighting;
    }

    public override void ReceiveHit()
    {
        if (_currentHitElapsedTime >= _hitTime)
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
                if (_currentAttackElapsedTime >= _attackTime)
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

    public override void AttackDamageCallback()
    {
        _waitingForAttack = false;
        _enemyController.AttackPlayer();
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
    IEnumerator CoDissolve()
    {
        /*
         * 
         * Previous Dissolve
         * 
         */

        //_enemyController.GetEmbersPool().Play(transform.position);
        Material m = new Material(skinnedMeshRenderers[0].material);
        Color c = Color.black;
        Color transparentC = new Color(c.r, c.g, c.b, 0);
        foreach (SkinnedMeshRenderer sk in skinnedMeshRenderers)
        {
            sk.material = m;
        }
        yield return new WaitForSeconds(1f);
        float maskClip = 0;
        for (float i = 0; i < 6.0f; i += Time.deltaTime)
        {
            maskClip = (i / 6f);
            m.SetFloat("_Cutoff", maskClip - 0.03f);
            m.SetFloat("_EmissionClipValue", maskClip);
            yield return 0;
        }
        maskClip = 1;
        m.SetFloat("_Cutoff", 1f);
        m.SetFloat("_EmissionClipValue", 1f);
        Destroy(transform.root.gameObject);
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
